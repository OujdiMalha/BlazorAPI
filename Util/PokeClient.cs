using BlazorAPI.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorAPI.Util
{
    public class PokeClient
    {
        private readonly HttpClient _httpClient;

        public PokeClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            response.EnsureSuccessStatusCode(); // Optional: Ensure response is successful before reading content

            var content = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<Pokemon>(content, options);
        }
    }
}