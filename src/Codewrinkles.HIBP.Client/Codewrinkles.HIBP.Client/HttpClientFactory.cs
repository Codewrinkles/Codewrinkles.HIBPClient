namespace Codewrinkles.HIBP.Client
{
    internal class HttpClientFactory
    {
        internal static HttpClient? CreateDefault(string apiKey)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.Endpoints.BASE_ENDPOINT);
            client.DefaultRequestHeaders.Add("hibp-api-key", apiKey);
            client.Timeout = TimeSpan.FromSeconds(Constants.Endpoints.REQUEST_TIMEOUT);
            return client;
        }
    }
}