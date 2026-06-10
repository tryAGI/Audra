namespace Audra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AudraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("AUDRA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("AUDRA_API_KEY environment variable is not found.");

        var client = new AudraClient(apiKey);
        
        return client;
    }
}
