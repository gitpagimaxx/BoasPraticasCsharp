using System.Net.Http.Headers;

namespace Alura.Adopet.Console.Services;

public class ServiceCollection
{
    private static readonly string urlBase = "http://localhost:5057";

    public static HttpClient ConfiguraHttpClient()
    {
        HttpClient _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        _client.BaseAddress = new Uri(urlBase);
        return _client;
    }
}