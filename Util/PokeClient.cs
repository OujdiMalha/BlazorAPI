using System.Text.Json;

namespace BlazorAPI.Util
{
    public class PokeClient
    {
        public HttpClient HttpClient { get; set; }
        
        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }
        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}
