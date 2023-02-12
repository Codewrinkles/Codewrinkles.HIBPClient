namespace Codewrinkles.HIBP.Client.Options;

/// <summary>
/// This class captures various options that can be specified
/// when making API requests to the Have I Been Pwned API. 
/// The class is used to configure the API requests and provide
/// values for certain options that are required or can be customized.
/// </summary>
public class HibpClientOptions
{
    /// <summary>
    /// A string property that holds the API key required for
    /// using the Have I Been Pwned API. This key is sent as
    /// a header in API requests and is used to identify the
    /// application making the request.
    /// </summary>
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// This holds any custom headers to be sent with API requests.
    /// This allows developers to specify additional headers as needed
    /// to customize the API request behavior.
    /// </summary>
    public Dictionary<string, string> Headers { get; set; }

    /// <summary>
    /// It  holds the user agent string to be sent with API requests.
    /// This string can be used to identify the application making the API request.
    /// </summary>
    public string UserAgent { get; set; } = string.Empty;

    /// <summary>
    /// It holds the base URL for the Have I Been Pwned API.
    /// This URL is used to build the full API endpoint for each API request.
    /// It's assigned as a constant string in the Constants class.
    /// </summary>
    public string BaseAddress { get; set; }

    /// <summary>
    /// It indicates whether unverified breaches should be included
    /// in the API response. When this property is set to 'true',
    /// API responses will include information about unverified breaches,
    /// otherwise they will only include information about verified breaches.
    /// </summary>
    public bool IncludeUnverifiedBreaches { get; set; }

    /// <summary>
    /// It indicates whether the API response should be truncated
    /// to only include the name of each breach. When this property
    /// is set to true, API responses will only include the name of
    /// each breach, otherwise they will include full information about each breach.
    /// </summary>
    public bool TruncateResponse { get; set; }

    /// <summary>
    /// Set this way, the constructor allows developers to create
    /// an instance of the HibpClientOptions class without specifying
    /// any options. The default values set in the constructor provide
    /// a reasonable starting point for making API requests, which can
    /// then be modified as needed by setting the properties of the
    /// HibpClientOptions instance.
    /// </summary>
    public HibpClientOptions()
    {
        Headers = new Dictionary<string, string>();
        BaseAddress = Constants.BASE_ENDPOINT;
        IncludeUnverifiedBreaches = false;
        TruncateResponse = false;
    }
}
