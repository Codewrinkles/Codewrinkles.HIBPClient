using Codewrinkles.HIBP.Client.Exceptions;
using Codewrinkles.HIBP.Client.Options;

namespace Codewrinkles.HIBP.Client
{
    internal class HttpClientFactory
    {
        /// <summary>
        /// Create default HttpClient with no options specified
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns>HttpClient</returns>
        internal static HttpClient? CreateDefault(string apiKey)
        {
            var client = new HttpClient();
            GetBaseAddress(client, null!);
            client.DefaultRequestHeaders.Add("hibp-api-key", apiKey);
            client.Timeout = TimeSpan.FromSeconds(Constants.API.REQUEST_TIMEOUT);
            return client;
        }

        /// <summary>
        /// Create HttpClient with options specified
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        internal static HttpClient? CreateWithOptions(HibpClientOptions options)
        {
            var client = new HttpClient();

            SetApiKey(client, options);
            SetBaseAddress(client, options);
            AppendHeaders(client, options);
            client.Timeout = TimeSpan.FromSeconds(Constants.API.REQUEST_TIMEOUT);
            return client;
        }

        private static void AppendHeaders(HttpClient? client, HibpClientOptions options)
        {
            if(options is null)
                return;
            else
                foreach(var header in options.Headers)
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        private static void SetBaseAddress(HttpClient? client, HibpClientOptions options)
        {
            if(options is null)
                client.BaseAddress = new Uri(Constants.API.BASE_ENDPOINT);
            else
                client.BaseAddress = new Uri(options.BaseAddress);
        }

        private static void SetApiKey(HttpClient? client, HibpClientOptions options)
        {
            if(options is null)
                throw new ApiKeyException(Constants.ErrorMessages.API_KEY_CANNOT_BE_EMPTY);
            else
                client.DefaultRequestHeaders.Add(Constants.API.API_KEY_HEADER, options.ApiKey);
        }
    }
}