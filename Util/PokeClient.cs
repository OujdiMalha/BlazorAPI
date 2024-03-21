using BlazorAPI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorAPI.Util
{
    public class PokeClient
    {
        private readonly HttpClient _httpClient;

        // Constructeur prenant HttpClient en paramètre pour les requêtes HTTP
        public PokeClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        // Méthode pour récupérer un Pokemon par son ID
        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            response.EnsureSuccessStatusCode();

            // Lecture du contenu de la réponse
            var content = await response.Content.ReadAsStringAsync();

            // Options pour la désérialisation JSON
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Désérialisation du contenu JSON en objet Pokemon
            return JsonSerializer.Deserialize<Pokemon>(content, options);
        }

        // Méthode pour marquer un Pokemon comme favori
        public async Task ToggleFavoritePokemon(int pokemonId, bool isFavorite)
        {
            // Création de données JSON à envoyer dans la requête
            var data = new StringContent(JsonSerializer.Serialize(new { PokemonId = pokemonId, IsFavorite = isFavorite }), Encoding.UTF8, "application/json");

            // Envoi d'une requête PUT pour mettre à jour le statut de favori du Pokemon
            var response = await _httpClient.PutAsync($"https://pokeapi.co/api/v2/pokemon/favorite/{pokemonId}", data);
            response.EnsureSuccessStatusCode();
        }

        // Méthode pour supprimer un Pokemon
        public async Task DeletePokemon(int pokemonId)
        {
            // Envoi d'une requête DELETE pour supprimer le Pokemon
            var response = await _httpClient.DeleteAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonId}");
            response.EnsureSuccessStatusCode();
        }

        // Méthode pour mettre à jour un Pokemon
        public async Task UpdatePokemon(Pokemon pokemon)
        {
            // Création de données JSON à envoyer dans la requête
            var data = new StringContent(JsonSerializer.Serialize(pokemon), Encoding.UTF8, "application/json");

            // Envoi d'une requête PUT pour mettre à jour le Pokemon
            var response = await _httpClient.PutAsync($"https://pokeapi.co/api/v2/pokemon/{pokemon.id}", data);
            response.EnsureSuccessStatusCode();
        }

        // Méthode pour récupérer les Pokémon favoris
        public async Task<List<Pokemon>> GetFavoritePokemon()
        {
            var response = await _httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/favorite");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Pokemon>>(content, options);
        }
    }
}