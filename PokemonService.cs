using System.Net.Http.Json;
using BlazorPokeApi.Models;

namespace BlazorPokeApi.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon?> BuscarPokemonAsync(string nome)
        {
            try
            {
                return await _httpClient
                    .GetFromJsonAsync<Pokemon>($"pokemon/{nome.ToLower()}");
            }
            catch
            {
                return null;
            }
        }
    }
}