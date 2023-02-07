using Codewrinkles.HIBP.Client.Abstractions;

namespace Codewrinkles.HIBP.Client;

public class HibpClient : IHibpClient, IDisposable
{
    private readonly HttpClient _httpClient;

    internal HibpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public HibpClient(string apiKey)
    {
        _httpClient = HttpClientFactory.CreateDefault(apiKey);
    }
    public void Dispose()
    {
        _httpClient.Dispose();
    }
}