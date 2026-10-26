using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocSpring.Client.Model;

namespace DocSpring.Client.Client
{
    /// <summary>
    /// Thrown before a request is sent when the API would reject it with a 422. Details are the API's error details:
    /// each has a Code, a Message and a Pointer into the body (or a Parameter for a query parameter).
    /// </summary>
    public class ValidationException : ArgumentException
    {
        /// <summary>The API's error details for the request</summary>
        public IReadOnlyList<ErrorDetail> Details { get; }

        /// <summary>Creates the exception for the request's error details</summary>
        public ValidationException(IReadOnlyList<ErrorDetail> details) : base(Describe(details))
        {
            Details = details;
        }

        private static string Describe(IReadOnlyList<ErrorDetail> details)
        {
            var shown = details.Take(3).Select(detail =>
            {
                var subject = detail.PointerOption.IsSet ? detail.Pointer : detail.Parameter;
                return (subject == "" ? "the request body" : subject) + " " + detail.Message;
            });
            var message = "Invalid request: " + string.Join("; ", shown);
            if (details.Count > 3) message += $" (and {details.Count - 3} more)";
            return message;
        }
    }

    /// <summary>
    /// Checks a request against API v2's request schemas (request_schemas.json, the schemas the API validates requests
    /// with) before it's sent, and says what the API would say about it. api_clients/validator_conformance checks that
    /// it agrees with the API.
    /// </summary>
    public static class RequestValidator
    {
        private static readonly Dictionary<string, string> TypeNames = new Dictionary<string, string>
        {
            ["string"] = "a string",
            ["integer"] = "an integer",
            ["number"] = "a number",
            ["boolean"] = "true or false",
            ["object"] = "an object",
            ["array"] = "an array",
            ["null"] = "null",
        };
        // What a multipart body's file field holds when the API checks it
        private const string FilePlaceholder = "(file)";
        // A date and time as the API reads it (Ruby's DateTime.rfc3339, then json_schemer's checks)
        private static readonly Regex DateTime = new Regex(
            @"\A[ \t\n\v\f\r]*(-?[0-9]{4})-([0-9]{2})-([0-9]{2})[Tt \t\n\v\f\r]([0-9]{2}):([0-9]{2}):([0-9]{2})(?:\.[0-9]+)?(?:[Zz]|([+-])([0-9]{2}):([0-9]{2}))\z");
        // An absolute URI as the API reads it (RFC 3986, as Ruby's URI parser has it), a little looser for IP addresses
        // Lookaheads check the escapes, so only character classes repeat: Java and PHP recurse on each repetition of a group
        private const string Segment = "[%!$&-.0-9:;=@A-Z_a-z~/]";
        private static readonly Regex Uri = new Regex(
            @"\A(?![^?#]*%(?![0-9A-Fa-f]{2}))[A-Za-z][+\-.0-9A-Za-z]*:" +
            "(?://(?:[%!$&-.0-9:;=A-Z_a-z~]*@)?" +
            @"(?:\[(?:[0-9A-Fa-f:.]+|[vV][0-9A-Fa-f]+\.[!$&-.0-9:;=A-Z_a-z~]+)\]|[%!$&-.0-9;=A-Z_a-z~]*)" +
            "(?::[0-9]*)?(?:/" + Segment + "*)?" +
            "|/(?:(?!/)" + Segment + "+)?" +
            "|(?!/)" + Segment + "+" +
            "|)" +
            @"(?:\?[^#]*)?" +
            @"(?:#(?![^#]*%(?![0-9A-Fa-f]{2}))[%!$&-.0-9:;=@A-Z_a-z~/?]*)?\z");
        private static readonly Regex Whitespace = new Regex("[ \t\n\v\f\r]");
        private static readonly Regex IntegerString = new Regex(@"\A-?[0-9]+\z");
        private static readonly Regex NumberString = new Regex(@"\A-?[0-9]+(?:\.[0-9]+)?\z");
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        private static readonly ConcurrentDictionary<string, Regex> Patterns = new ConcurrentDictionary<string, Regex>();
        private static readonly Lazy<JsonElement> Schemas = new Lazy<JsonElement>(LoadSchemas);

        /// <summary>
        /// Throws a ValidationException when the API would reject the request to an operation (createSubmission). The
        /// API client calls this before sending each request, unless its ValidateRequests setting is off.
        /// </summary>
        public static async Task ValidateRequestAsync(string operationId, HttpRequestMessage request)
        {
            var query = new Dictionary<string, string>();
            var parsed = System.Web.HttpUtility.ParseQueryString(request.RequestUri?.Query ?? "");
            foreach (string name in parsed.AllKeys)
            {
                if (name != null && !query.ContainsKey(name)) query[name] = parsed[name];
            }

            JsonElement? body = null;
            if (request.Content is MultipartFormDataContent multipart)
            {
                var values = new Dictionary<string, string>();
                foreach (var part in multipart)
                {
                    var name = part.Headers.ContentDisposition?.Name?.Trim('"');
                    if (name == null) continue;
                    values[name] = part is StringContent ? await part.ReadAsStringAsync().ConfigureAwait(false) : FilePlaceholder;
                }
                body = JsonSerializer.SerializeToElement(values);
            }
            else if (request.Content is StringContent)
            {
                var text = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (text.Length > 0)
                {
                    using (var document = JsonDocument.Parse(text)) body = document.RootElement.Clone();
                }
            }

            var details = Errors(operationId, JsonSerializer.SerializeToElement(query), body);
            if (details.Count > 0) throw new ValidationException(details);
        }

        /// <summary>The details for a request to an operation (createSubmission)</summary>
        public static List<ErrorDetail> Errors(string operationId, JsonElement query, JsonElement? body)
        {
            var details = new List<ErrorDetail>();
            if (!Schemas.Value.GetProperty("operations").TryGetProperty(operationId, out var entry)) return details;

            if (entry.TryGetProperty("query", out var queryParams) && query.ValueKind == JsonValueKind.Object && query.EnumerateObject().Any())
            {
                var properties = new Dictionary<string, JsonElement>();
                var required = new List<string>();
                foreach (var param in queryParams.EnumerateObject())
                {
                    properties[param.Name] = param.Value.GetProperty("schema");
                    if (param.Value.TryGetProperty("required", out var isRequired) && isRequired.ValueKind == JsonValueKind.True) required.Add(param.Name);
                }
                var schema = JsonSerializer.SerializeToElement(new Dictionary<string, object>
                {
                    ["type"] = "object",
                    ["properties"] = properties,
                    ["required"] = required,
                    ["additionalProperties"] = false,
                });
                details.AddRange(ValidateParams(schema, query, "query"));
            }
            if (entry.TryGetProperty("body", out var bodyEntry) && body.HasValue && body.Value.ValueKind != JsonValueKind.Null)
            {
                var schema = bodyEntry.GetProperty("schema");
                if (bodyEntry.GetProperty("mediaType").GetString() == "multipart/form-data")
                    details.AddRange(ValidateParams(schema, body.Value, "body"));
                else
                    details.AddRange(Validate(schema, body.Value, "body"));
            }
            return details;
        }

        /// <summary>The details for data checked against a schema at a location (body or query)</summary>
        public static List<ErrorDetail> Validate(JsonElement schema, JsonElement data, string location)
        {
            var details = new List<ErrorDetail>();
            Check(schema, data, "", location, details);
            return details;
        }

        private static JsonElement LoadSchemas()
        {
            var assembly = typeof(RequestValidator).Assembly;
            var resource = assembly.GetManifestResourceNames().FirstOrDefault(name => name.EndsWith("request_schemas.json", StringComparison.Ordinal));
            if (resource == null) throw new InvalidOperationException("request_schemas.json is missing from the DocSpring.Client assembly");
            using (var stream = assembly.GetManifestResourceStream(resource))
            using (var document = JsonDocument.Parse(stream))
            {
                return document.RootElement.Clone();
            }
        }

        // Query and multipart params arrive as strings, which the API converts where the schema types them
        private static List<ErrorDetail> ValidateParams(JsonElement schema, JsonElement data, string location)
        {
            schema.TryGetProperty("properties", out var properties);
            var converted = new Dictionary<string, JsonElement>();
            foreach (var field in data.EnumerateObject())
            {
                JsonElement property = default;
                var hasSchema = properties.ValueKind == JsonValueKind.Object && properties.TryGetProperty(field.Name, out property);
                converted[field.Name] = hasSchema ? ConvertParam(field.Value, property) : field.Value;
            }
            return Validate(schema, JsonSerializer.SerializeToElement(converted), location);
        }

        private static JsonElement ConvertParam(JsonElement value, JsonElement schema)
        {
            if (schema.ValueKind != JsonValueKind.Object) return value;
            var types = TypesOf(schema);
            if (value.ValueKind == JsonValueKind.Array && types.Contains("array"))
            {
                schema.TryGetProperty("items", out var items);
                return JsonSerializer.SerializeToElement(value.EnumerateArray().Select(item => ConvertParam(item, items)).ToList());
            }
            if (value.ValueKind != JsonValueKind.String) return value;

            var text = value.GetString();
            if (types.Contains("integer") && IntegerString.IsMatch(text)) return Number(BigInteger.Parse(text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture));
            if (types.Contains("number") && NumberString.IsMatch(text))
            {
                return text.Contains(".")
                    ? JsonSerializer.SerializeToElement(double.Parse(text, CultureInfo.InvariantCulture))
                    : Number(BigInteger.Parse(text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture));
            }
            if (types.Contains("boolean") && (text == "true" || text == "false")) return JsonSerializer.SerializeToElement(text == "true");
            return value;
        }

        private static JsonElement Number(string json)
        {
            using (var document = JsonDocument.Parse(json)) return document.RootElement.Clone();
        }

        private static List<string> TypesOf(JsonElement schema)
        {
            if (!schema.TryGetProperty("type", out var type)) return new List<string>();
            return type.ValueKind == JsonValueKind.Array ? type.EnumerateArray().Select(name => name.GetString()).ToList() : new List<string> { type.GetString() };
        }

        private static JsonElement Resolve(JsonElement schema)
        {
            var resolved = schema;
            while (resolved.ValueKind == JsonValueKind.Object && resolved.TryGetProperty("$ref", out var reference))
            {
                var name = reference.GetString().Replace("#/components/schemas/", "");
                if (!Schemas.Value.GetProperty("components").GetProperty("schemas").TryGetProperty(name, out resolved)) return default;
            }
            return resolved;
        }

        private static void Check(JsonElement rawSchema, JsonElement data, string pointer, string location, List<ErrorDetail> details)
        {
            var schema = Resolve(rawSchema);
            if (schema.ValueKind != JsonValueKind.Object) return;
            if (schema.TryGetProperty("discriminator", out var discriminator))
            {
                CheckUnion(discriminator, data, pointer, location, details);
                return;
            }

            if (schema.TryGetProperty("type", out _) && !TypesOf(schema).Any(type => IsType(data, type)))
            {
                var message = pointer == "" && location == "body" ? "must be a JSON object" : TypeMessage(TypesOf(schema));
                details.Add(Detail(location, pointer, "type", message));
            }
            if (schema.TryGetProperty("enum", out var values) && !values.EnumerateArray().Any(value => JsonEqual(value, data)))
            {
                details.Add(Detail(location, pointer, "enum", "must be one of: " + string.Join(", ", values.EnumerateArray().Select(ToJson))));
            }
            if (schema.TryGetProperty("const", out var constant) && !JsonEqual(constant, data))
            {
                details.Add(Detail(location, pointer, "const", "must be " + ToJson(constant)));
            }

            switch (data.ValueKind)
            {
                case JsonValueKind.String:
                    CheckString(schema, data.GetString(), pointer, location, details);
                    break;
                case JsonValueKind.Number:
                    CheckNumber(schema, data, pointer, location, details);
                    break;
                case JsonValueKind.Array:
                    CheckArray(schema, data, pointer, location, details);
                    break;
                case JsonValueKind.Object:
                    CheckObject(schema, data, pointer, location, details);
                    break;
            }
        }

        // A union (oneOf with a discriminator): the discriminator property's value picks the variant, and only that one
        // is checked, as the API does. The mapping is [value, $ref] pairs, in the order the API lists them.
        private static void CheckUnion(JsonElement discriminator, JsonElement data, string pointer, string location, List<ErrorDetail> details)
        {
            if (data.ValueKind != JsonValueKind.Object)
            {
                details.Add(Detail(location, pointer, "type", "must be " + TypeNames["object"]));
                return;
            }

            var name = discriminator.GetProperty("propertyName").GetString();
            var child = pointer + "/" + Escape(name);
            if (!data.TryGetProperty(name, out var value))
            {
                details.Add(Detail(location, child, "required", "is required"));
                return;
            }

            var shown = new List<string>();
            foreach (var pair in discriminator.GetProperty("mapping").EnumerateArray())
            {
                if (value.ValueKind == JsonValueKind.String && pair[0].GetString() == value.GetString())
                {
                    var variant = pair[1].GetString().Replace("#/components/schemas/", "");
                    Check(Schemas.Value.GetProperty("components").GetProperty("schemas").GetProperty(variant), data, pointer, location, details);
                    return;
                }
                shown.Add(ToJson(pair[0]));
            }
            details.Add(Detail(location, child, "enum", "must be one of: " + string.Join(", ", shown)));
        }

        private static void CheckString(JsonElement schema, string data, string pointer, string location, List<ErrorDetail> details)
        {
            var length = CodePoints(data);
            if (schema.TryGetProperty("minLength", out var minLength) && length < minLength.GetDouble())
            {
                details.Add(Detail(location, pointer, "minLength", AtLeast(minLength, "must be at least " + Count(minLength, "character"))));
            }
            if (schema.TryGetProperty("maxLength", out var maxLength) && length > maxLength.GetDouble())
            {
                details.Add(Detail(location, pointer, "maxLength", "must be at most " + Count(maxLength, "character")));
            }
            if (schema.TryGetProperty("pattern", out var source))
            {
                var compiled = Pattern(source.GetString());
                if (compiled != null && !compiled.IsMatch(data))
                {
                    var message = schema.TryGetProperty("x-pattern-message", out var custom) ? custom.GetString() : "must match the pattern " + source.GetString();
                    details.Add(Detail(location, pointer, "pattern", message));
                }
            }
            if (schema.TryGetProperty("format", out var format) && !Format(format.GetString(), data))
            {
                var message = Schemas.Value.GetProperty("formatMessages").TryGetProperty(format.GetString(), out var custom)
                    ? custom.GetString()
                    : "must be a valid " + format.GetString();
                details.Add(Detail(location, pointer, "format", message));
            }
        }

        private static void CheckNumber(JsonElement schema, JsonElement data, string pointer, string location, List<ErrorDetail> details)
        {
            if (schema.TryGetProperty("minimum", out var limit) && Compare(data, limit) < 0)
                details.Add(Detail(location, pointer, "minimum", "must be at least " + limit.GetRawText()));
            if (schema.TryGetProperty("maximum", out limit) && Compare(data, limit) > 0)
                details.Add(Detail(location, pointer, "maximum", "must be at most " + limit.GetRawText()));
            if (schema.TryGetProperty("exclusiveMinimum", out limit) && Compare(data, limit) <= 0)
                details.Add(Detail(location, pointer, "exclusiveMinimum", "must be greater than " + limit.GetRawText()));
            if (schema.TryGetProperty("exclusiveMaximum", out limit) && Compare(data, limit) >= 0)
                details.Add(Detail(location, pointer, "exclusiveMaximum", "must be less than " + limit.GetRawText()));
        }

        private static void CheckArray(JsonElement schema, JsonElement data, string pointer, string location, List<ErrorDetail> details)
        {
            var items = data.EnumerateArray().ToList();
            if (schema.TryGetProperty("minItems", out var minItems) && items.Count < minItems.GetDouble())
            {
                details.Add(Detail(location, pointer, "minItems", AtLeast(minItems, "must have at least " + Count(minItems, "item"))));
            }
            if (schema.TryGetProperty("maxItems", out var maxItems) && items.Count > maxItems.GetDouble())
            {
                details.Add(Detail(location, pointer, "maxItems", "must have at most " + Count(maxItems, "item")));
            }
            if (schema.TryGetProperty("uniqueItems", out var unique) && unique.ValueKind == JsonValueKind.True && !Unique(items))
            {
                var duplicate = FirstDuplicate(items);
                var message = duplicate.HasValue ? "has " + ToJson(duplicate.Value) + " more than once" : "can't contain the same item twice";
                details.Add(Detail(location, pointer, "uniqueItems", message));
            }
            if (schema.TryGetProperty("items", out var itemSchema))
            {
                for (var index = 0; index < items.Count; index++)
                    Check(itemSchema, items[index], pointer + "/" + index.ToString(CultureInfo.InvariantCulture), location, details);
            }
        }

        private static void CheckObject(JsonElement schema, JsonElement data, string pointer, string location, List<ErrorDetail> details)
        {
            if (schema.TryGetProperty("required", out var required))
            {
                foreach (var name in required.EnumerateArray().Select(name => name.GetString()))
                {
                    if (!data.TryGetProperty(name, out _)) details.Add(Detail(location, pointer + "/" + Escape(name), "required", "is required"));
                }
            }

            schema.TryGetProperty("properties", out var properties);
            schema.TryGetProperty("additionalProperties", out var additional);
            foreach (var field in data.EnumerateObject())
            {
                var child = pointer + "/" + Escape(field.Name);
                if (properties.ValueKind == JsonValueKind.Object && properties.TryGetProperty(field.Name, out var property))
                    Check(property, field.Value, child, location, details);
                else if (additional.ValueKind == JsonValueKind.False)
                    details.Add(UnknownProperty(schema, field.Name, child, location));
                else if (additional.ValueKind == JsonValueKind.Object)
                    Check(additional, field.Value, child, location, details);
            }
        }

        private static ErrorDetail UnknownProperty(JsonElement schema, string name, string pointer, string location)
        {
            if (schema.TryGetProperty("x-not-allowed-properties", out var notAllowed) && notAllowed.TryGetProperty(name, out var reason))
                return Detail(location, pointer, "not_allowed", reason.GetString());

            var noun = location == "query" ? "query parameter" : "property";
            var hasCustom = schema.TryGetProperty("x-unknown-property-message", out var custom);
            var message = hasCustom ? custom.GetString() : "isn't a documented " + noun;
            var snake = Underscore(name);
            if (snake != name && schema.TryGetProperty("properties", out var properties) && properties.TryGetProperty(snake, out _))
            {
                var plural = hasCustom ? "settings" : noun == "property" ? "properties" : "query parameters";
                message += ". API v2 names " + plural + " in snake_case: '" + snake + "'";
            }
            return Detail(location, pointer, "unknown_property", message);
        }

        private static ErrorDetail Detail(string location, string pointer, string code, string message)
        {
            if (location != "query") return new ErrorDetail(code, message, pointer: new Option<string>(pointer));

            var parameter = pointer.Substring(1).Split('/')[0].Replace("~1", "/").Replace("~0", "~");
            return new ErrorDetail(code, message, parameter: new Option<string>(parameter));
        }

        private static bool IsType(JsonElement data, string type)
        {
            switch (type)
            {
                case "string":
                    return data.ValueKind == JsonValueKind.String;
                case "integer":
                    if (data.ValueKind != JsonValueKind.Number) return false;
                    if (IsIntegral(data)) return true;
                    var value = data.GetDouble();
                    return !double.IsInfinity(value) && !double.IsNaN(value) && value == Math.Floor(value);
                case "number":
                    return data.ValueKind == JsonValueKind.Number;
                case "boolean":
                    return data.ValueKind == JsonValueKind.True || data.ValueKind == JsonValueKind.False;
                case "object":
                    return data.ValueKind == JsonValueKind.Object;
                case "array":
                    return data.ValueKind == JsonValueKind.Array;
                case "null":
                    return data.ValueKind == JsonValueKind.Null;
                default:
                    return false;
            }
        }

        // A number written without a fraction or an exponent, which the API reads as an integer
        private static bool IsIntegral(JsonElement number)
        {
            var text = number.GetRawText();
            return text.IndexOfAny(new[] { '.', 'e', 'E' }) < 0;
        }

        private static int Compare(JsonElement left, JsonElement right)
        {
            if (IsIntegral(left) && IsIntegral(right))
                return BigInteger.Parse(left.GetRawText(), CultureInfo.InvariantCulture).CompareTo(BigInteger.Parse(right.GetRawText(), CultureInfo.InvariantCulture));
            return left.GetDouble().CompareTo(right.GetDouble());
        }

        // Patterns are ECMA-262 regexps, as OpenAPI says: ^ and $ are the start and end of the value, not of a line.
        // The API's patterns only use ^ as the first character and $ as the last
        // (api_clients/scripts/extract_request_schemas). RegexOptions.ECMAScript makes \d match only 0-9, as it does
        // on the API. A pattern .NET can't compile isn't checked.
        private static Regex Pattern(string source)
        {
            return Patterns.GetOrAdd(source, key =>
            {
                var anchored = key.StartsWith("^", StringComparison.Ordinal) ? @"\A" + key.Substring(1) : key;
                // A $ after an even number of backslashes is the anchor
                if (anchored.EndsWith("$", StringComparison.Ordinal))
                {
                    var backslashes = 0;
                    while (backslashes < anchored.Length - 1 && anchored[anchored.Length - 2 - backslashes] == '\\') backslashes++;
                    if (backslashes % 2 == 0) anchored = anchored.Substring(0, anchored.Length - 1) + @"\z";
                }
                try
                {
                    return new Regex(anchored, RegexOptions.ECMAScript);
                }
                catch (ArgumentException)
                {
                    return null;
                }
            });
        }

        private static bool Format(string name, string data)
        {
            if (name == "uri") return data.All(character => character <= 0x7f) && !Whitespace.IsMatch(data) && Uri.IsMatch(data);
            if (name == "date-time") return IsDateTime(data);
            return true;
        }

        private static bool IsDateTime(string data)
        {
            var match = DateTime.Match(data);
            if (!match.Success) return false;

            var numbers = Enumerable.Range(1, 6).Select(group => int.Parse(match.Groups[group].Value, CultureInfo.InvariantCulture)).ToArray();
            int year = numbers[0], month = numbers[1], day = numbers[2], hour = numbers[3], minute = numbers[4], second = numbers[5];
            if (month < 1 || month > 12 || day < 1 || day > DaysInMonth(year, month)) return false;
            if (hour > 23 || minute > 59 || second > 60) return false;

            var offset = 0;
            if (match.Groups[7].Success)
            {
                var offsetHours = int.Parse(match.Groups[8].Value, CultureInfo.InvariantCulture);
                var offsetMinutes = int.Parse(match.Groups[9].Value, CultureInfo.InvariantCulture);
                if (offsetHours > 23 || offsetMinutes > 59) return false;
                offset = (match.Groups[7].Value == "-" ? -1 : 1) * (offsetHours * 60 + offsetMinutes);
            }
            // A leap second is only at the end of a UTC day
            return second < 60 || ((hour * 60 + minute - offset) % 1440 + 1440) % 1440 == 1439;
        }

        // Before the Gregorian calendar (1582), the API's dates are Julian: every fourth year is a leap year
        private static int DaysInMonth(int year, int month)
        {
            var leap = year % 4 == 0 && (year < 1583 || year % 100 != 0 || year % 400 == 0);
            if (month == 2 && leap) return 29;
            return new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }[month - 1];
        }

        private static bool Unique(List<JsonElement> items)
        {
            for (var index = 0; index < items.Count; index++)
            {
                for (var other = index + 1; other < items.Count; other++)
                {
                    if (JsonEqual(items[index], items[other])) return false;
                }
            }
            return true;
        }

        // The first value that's in the list twice, as the API names it
        private static JsonElement? FirstDuplicate(List<JsonElement> items)
        {
            var counts = new Dictionary<string, int>();
            var firsts = new Dictionary<string, JsonElement>();
            var order = new List<string>();
            foreach (var item in items)
            {
                var key = TallyKey(item);
                if (!counts.ContainsKey(key))
                {
                    counts[key] = 0;
                    firsts[key] = item;
                    order.Add(key);
                }
                counts[key]++;
            }
            foreach (var key in order)
            {
                if (counts[key] > 1) return firsts[key];
            }
            return null;
        }

        private static string TallyKey(JsonElement value)
        {
            switch (value.ValueKind)
            {
                case JsonValueKind.Array:
                    return "[" + string.Join(",", value.EnumerateArray().Select(TallyKey)) + "]";
                case JsonValueKind.Object:
                    return "{" + string.Join(",", value.EnumerateObject()
                        .OrderBy(field => field.Name, StringComparer.Ordinal)
                        .Select(field => JsonSerializer.Serialize(field.Name, JsonOptions) + ":" + TallyKey(field.Value))) + "}";
                default:
                    return ToJson(value);
            }
        }

        // JSON equality: numbers by value, objects regardless of key order
        private static bool JsonEqual(JsonElement left, JsonElement right)
        {
            if (left.ValueKind == JsonValueKind.Number || right.ValueKind == JsonValueKind.Number)
                return left.ValueKind == JsonValueKind.Number && right.ValueKind == JsonValueKind.Number && Compare(left, right) == 0;
            if (left.ValueKind != right.ValueKind) return false;
            switch (left.ValueKind)
            {
                case JsonValueKind.Array:
                    var leftItems = left.EnumerateArray().ToList();
                    var rightItems = right.EnumerateArray().ToList();
                    return leftItems.Count == rightItems.Count && leftItems.Zip(rightItems, JsonEqual).All(equal => equal);
                case JsonValueKind.Object:
                    var leftFields = left.EnumerateObject().ToList();
                    if (leftFields.Count != right.EnumerateObject().Count()) return false;
                    return leftFields.All(field => right.TryGetProperty(field.Name, out var other) && JsonEqual(field.Value, other));
                case JsonValueKind.String:
                    return left.GetString() == right.GetString();
                default:
                    return true;
            }
        }

        private static string TypeMessage(List<string> types)
        {
            var names = types.Select(type => TypeNames.TryGetValue(type, out var name) ? name : type).ToList();
            var connector = names.Count > 1 && names.Any(name => name.Contains(" or ")) ? ", or " : " or ";
            if (names.Count == 1) return "must be " + names[0];
            if (names.Count == 2) return "must be " + string.Join(connector, names);
            return "must be " + string.Join(", ", names.Take(names.Count - 1)) + connector + names[names.Count - 1];
        }

        private static string AtLeast(JsonElement limit, string message)
        {
            return limit.GetDouble() == 1 ? "can't be empty" : message;
        }

        private static string Count(JsonElement number, string noun)
        {
            return number.GetRawText() + " " + (number.GetDouble() == 1 ? noun : noun + "s");
        }

        private static int CodePoints(string text)
        {
            var count = 0;
            for (var index = 0; index < text.Length; index++)
            {
                if (char.IsHighSurrogate(text[index]) && index + 1 < text.Length && char.IsLowSurrogate(text[index + 1])) index++;
                count++;
            }
            return count;
        }

        private static string ToJson(JsonElement value)
        {
            return JsonSerializer.Serialize(value, JsonOptions);
        }

        private static string Escape(string token)
        {
            return token.Replace("~", "~0").Replace("/", "~1");
        }

        private static string Underscore(string name)
        {
            name = Regex.Replace(name, "([A-Z0-9]+)([A-Z][a-z])", "$1_$2");
            name = Regex.Replace(name, "([a-z0-9])([A-Z])", "$1_$2");
            return name.Replace("-", "_").ToLowerInvariant();
        }
    }
}
