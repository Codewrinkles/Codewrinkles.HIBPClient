namespace Codewrinkles.HIBP.Client.Options;

public class HibpClientOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public Dictionary<string, string> Headers { get; set; }
    public string UserAgent { get; set; } = string.Empty;
    public string BaseAddress { get; set; }
    public bool IncludeUnverifiedBreaches { get; set; }
    public bool TruncateResponse { get; set; }

    public HibpClientOptions()
    {
        Headers = new Dictionary<string, string>();
        BaseAddress = Constants.BaseAddress;
        IncludeUnverifiedBreaches = false;
        TruncateResponse = false;
    }
}