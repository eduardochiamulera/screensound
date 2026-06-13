using System.Net.Http.Json;
using ScreenSound.Shared.Modelos.Requests;
using ScreenSound.Shared.Modelos.Response;

namespace ScreenSound.WebAssembly.Services;

public class ArtistasAPI
{
    private readonly HttpClient _httpClient;

    public ArtistasAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ArtistaResponse>> GetArtitasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("artistas");
    }

    public async Task CadastrarArtistaAsync(ArtistaRequest request)
    {
        await _httpClient.PostAsJsonAsync("artistas", request);
    }
}
