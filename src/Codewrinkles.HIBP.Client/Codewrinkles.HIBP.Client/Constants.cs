namespace Codewrinkles.HIBP.Client;

internal static class Constants
{

    public static class API
    {
        const string VERSION = "V3";
        internal const string API_KEY_HEADER = "hibp-api-key";
        public const int REQUEST_TIMEOUT = 30;
        public const string BASE_ENDPOINT = $"https://haveibeenpwned.com/api/{VERSION}";
    }

    public static class Endpoints
    {

    }

    public static class ErrorMessages 
    {
        internal const string PROVIDE_API_KEY = "Please provide a valid API key.";        
        internal const string API_KEY_CANNOT_BE_EMPTY = "API key cannot be empty.";
    }

}