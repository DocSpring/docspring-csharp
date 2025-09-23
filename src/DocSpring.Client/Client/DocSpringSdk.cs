using DocSpring.Client.Api;

namespace DocSpring
{
    // Simple facade for creating the API client without deep namespaces.
    public static class Sdk
    {
        public static IClient NewClient(
            string apiTokenId,
            string apiTokenSecret,
            string host = null,
            string region = null)
        {
            return DocSpring.Client.Client.EnvClientFactory.NewClient(apiTokenId, apiTokenSecret, host, region);
        }

        public static IClient NewClientFromEnv()
        {
            return DocSpring.Client.Client.EnvClientFactory.NewClientFromEnv();
        }
    }
}

