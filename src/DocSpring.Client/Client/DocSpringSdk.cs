using DocSpring.Client.Api;

namespace DocSpring
{
    /// <summary>
    /// Creates the API client without deep namespaces: DocSpring.Sdk.NewClient(...) and DocSpring.Sdk.NewClientFromEnv().
    /// </summary>
    public static class Sdk
    {
        /// <summary>
        /// Creates a client. A parameter that's null or empty falls back to its environment variable.
        /// </summary>
        /// <param name="apiTokenId">API token ID (DOCSPRING_TOKEN_ID)</param>
        /// <param name="apiTokenSecret">API token secret (DOCSPRING_TOKEN_SECRET)</param>
        /// <param name="host">API host, such as sync.api-eu.docspring.com (DOCSPRING_HOST)</param>
        /// <param name="region">US or EU, used when there's no host (DOCSPRING_REGION). US by default.</param>
        /// <exception cref="System.ArgumentException">The region isn't US or EU.</exception>
        public static IClient NewClient(
            string apiTokenId,
            string apiTokenSecret,
            string host = null,
            string region = null)
        {
            return DocSpring.Client.Client.EnvClientFactory.NewClient(apiTokenId, apiTokenSecret, host, region);
        }

        /// <summary>
        /// Creates a client from DOCSPRING_TOKEN_ID, DOCSPRING_TOKEN_SECRET, DOCSPRING_HOST and DOCSPRING_REGION.
        /// </summary>
        /// <exception cref="System.ArgumentException">DOCSPRING_REGION isn't US or EU.</exception>
        public static IClient NewClientFromEnv()
        {
            return DocSpring.Client.Client.EnvClientFactory.NewClientFromEnv();
        }
    }
}

