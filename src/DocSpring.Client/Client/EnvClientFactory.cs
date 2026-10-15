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
    /// DOCSPRING_HOST takes precedence over DOCSPRING_REGION. Invalid region throws ArgumentException.
    /// </summary>
    public static class EnvClientFactory
    {
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

            if (string.IsNullOrWhiteSpace(apiTokenId) || string.IsNullOrWhiteSpace(apiTokenSecret))
            {
                throw new InvalidOperationException("Missing API token. Set DOCSPRING_TOKEN_ID and DOCSPRING_TOKEN_SECRET or pass explicitly.");
            }

            var baseUrl = ResolveBaseUrl(host, region);

            var builder = Host.CreateDefaultBuilder()
                .ConfigureApi((context, services, options) =>
                {
                    var token = new BasicToken(apiTokenId, apiTokenSecret);
                    options.AddTokens(token);
                    options.AddApiHttpClients(client =>
                    {
                        client.BaseAddress = new Uri(baseUrl);
                    }, http => { });
                });

            var h = builder.Build();
            return h.Services.GetRequiredService<IClient>();
        }

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
                    throw new ArgumentException($"Invalid DOCSPRING_REGION: {region}. Expected US or EU.");
            }
        }

        private static string NormalizeBaseUrl(string h)
        {
            h = h.Trim();
            if (!h.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !h.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                h = "https://" + h;
            }
            // Ensure a single /api/v1 suffix
            h = h.TrimEnd('/');
            if (!h.EndsWith("/api/v1", StringComparison.OrdinalIgnoreCase))
            {
                h += "/api/v1";
            }
            return h;
        }
    }
}
