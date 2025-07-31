namespace McpServers.Playground;

internal class GlobalHelpers
{
    internal static bool Verify()
    {
        try
        {
            // USER CREDENTIALS
            // Get User's API KEY that allows them to access your services, set in the mcp.json configuration by the end user
            var providedCode = Environment.GetEnvironmentVariable("PLAYGROUND_API_KEY");

            if (string.IsNullOrEmpty(providedCode))
                return false;

            // SERVICE PROVIDER VERIFICATION
            // Do NOT hard code this in a real app, use Azure KeyVault or other secure mechanism by which to validate an API key.
            var expectedCode = "7a3697d2-SAMPLE-VALUE-6f67e742c857";

            return string.Equals(providedCode, expectedCode, StringComparison.OrdinalIgnoreCase);
        }
        catch (Exception)
        {
            return false;
        }
    }
}