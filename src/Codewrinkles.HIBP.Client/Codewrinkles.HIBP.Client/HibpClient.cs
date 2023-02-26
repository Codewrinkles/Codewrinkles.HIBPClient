using Codewrinkles.HIBP.Client.Abstractions;
using Codewrinkles.HIBP.Client.Options;

namespace Codewrinkles.HIBP.Client;

public class HibpClient : IHibpClient, IDisposable
{
    private readonly HttpClient _httpClient;
    /// <summary>
    /// Internal constructor that taks custom HttpClient
    /// </summary>
    /// <param name="httpClient"></param>
    internal HibpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    /// <summary>
    /// Accepts API key and creates default HttpClient
    /// </summary>
    /// <param name="apiKey"></param>
    public HibpClient(string apiKey)
    {
        _httpClient = HttpClientFactory.CreateDefault(apiKey);
    }
    /// <summary>
    /// Accepts HibpClientOptions and creates HttpClient with options
    /// </summary>
    /// <param name="options"></param>
    public HibpClient(HibpClientOptions options)
    {
        _httpClient = HttpClientFactory.CreateWithOptions(options);
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}