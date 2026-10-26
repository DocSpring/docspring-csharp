using System;
using System.Linq;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DocSpring.Client.Api;
using DocSpring.Client.Client;
using DocSpring.Client.Extensions;

namespace DocSpring.Client.Client
{
    /// <summary>
    /// Convenience factory to create an IClient using environment variables or explicit parameters.
    /// Supports DOCSPRING_TOKEN_ID / DOCSPRING_TOKEN_SECRET and DOCSPRING_HOST / DOCSPRING_REGION (US/EU).
    /// A parameter that's null or empty falls back to its environment variable. DOCSPRING_HOST takes precedence over
    /// DOCSPRING_REGION. Invalid region throws ArgumentException. Without credentials the client is still created, and
    /// the API's 401 response says what's missing.
    /// </summary>
    public static class EnvClientFactory
    {
        /// <summary>
        /// Creates a client. A parameter that's null or empty falls back to its environment variable.
        /// </summary>
        /// <param name="apiTokenId">API token ID (DOCSPRING_TOKEN_ID)</param>
        /// <param name="apiTokenSecret">API token secret (DOCSPRING_TOKEN_SECRET)</param>
        /// <param name="host">API host, such as sync.api-eu.docspring.com (DOCSPRING_HOST)</param>
        /// <param name="region">US or EU, used when there's no host (DOCSPRING_REGION). US by default.</param>
        /// <exception cref="ArgumentException">The region isn't US or EU.</exception>
        public static IClient NewClient(
            string apiTokenId = null,
            string apiTokenSecret = null,
            string host = null,
            string region = null)
        {
            if (string.IsNullOrEmpty(apiTokenId)) apiTokenId = Environment.GetEnvironmentVariable("DOCSPRING_TOKEN_ID");
            if (string.IsNullOrEmpty(apiTokenSecret)) apiTokenSecret = Environment.GetEnvironmentVariable("DOCSPRING_TOKEN_SECRET");
            if (string.IsNullOrEmpty(host)) host = Environment.GetEnvironmentVariable("DOCSPRING_HOST");
            if (string.IsNullOrEmpty(region)) region = Environment.GetEnvironmentVariable("DOCSPRING_REGION");

            var baseUrl = ResolveBaseUrl(host, region);

            var builder = Host.CreateDefaultBuilder()
                .ConfigureApi((context, options) =>
                {
                    // The generated client needs a token to send, so missing credentials are sent empty
                    var token = new BasicToken(apiTokenId ?? "", apiTokenSecret ?? "");
                    options.AddTokens(token);
                    options.AddApiHttpClients(client =>
                    {
                        client.BaseAddress = new Uri(baseUrl);
                    }, http => { });
                });

            var h = builder.Build();
            return h.Services.GetRequiredService<IClient>();
        }

        /// <summary>
        /// Creates a client from DOCSPRING_TOKEN_ID, DOCSPRING_TOKEN_SECRET, DOCSPRING_HOST and DOCSPRING_REGION.
        /// </summary>
        /// <exception cref="ArgumentException">DOCSPRING_REGION isn't US or EU.</exception>
        public static IClient NewClientFromEnv() => NewClient();

        private static string ResolveBaseUrl(string host, string region)
        {
            if (!string.IsNullOrWhiteSpace(host))
            {
                return NormalizeBaseUrl(host);
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                // Default to US if nothing provided
                return NormalizeBaseUrl("https://sync.api.docspring.com");
            }

            var r = region.Trim().ToUpperInvariant();
            switch (r)
            {
                case "US":
                    return NormalizeBaseUrl("https://sync.api.docspring.com");
                case "EU":
                    return NormalizeBaseUrl("https://sync.api-eu.docspring.com");
                default:
                    throw new ArgumentException($"{region} is not a valid region. Valid regions: US, EU");
            }
        }

        private static string NormalizeBaseUrl(string h)
        {
            h = h.Trim();
            if (!h.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !h.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                h = "https://" + h;
            }
            // Any API version's path (such as /api/v1 from a 3.x setup) becomes /api/v2
            h = h.TrimEnd('/');
            h = System.Text.RegularExpressions.Regex.Replace(h, @"/api/v\d+$", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase) + "/api/v2";
            return h;
        }
    }
}
