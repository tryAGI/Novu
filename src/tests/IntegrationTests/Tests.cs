namespace Novu.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NovuClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NOVU_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NOVU_API_KEY environment variable is not found.");

        var client = new NovuClient(apiKey);
        
        return client;
    }
}
