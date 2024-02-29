using System.Net.Http.Json;
using Pockemons.Contracts.Requests.Pockemons.Get;
using Pockemons.Core.Abstractions;
using Pockemons.Core.Entities;
using Pockemons.Core.Models.Pockemon;
using Pockemons.Core.Models.Pokemon;

namespace Pockemons.Core.Requests.Pokemons.Get;

/// <inheritdoc />
public class PokemonsGetHandler: IHandler<PokemonsGetResponse>
{
    private readonly PokemonsGetRequest _request;  
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="request">Запрос</param>
    public PokemonsGetHandler(
        PokemonsGetRequest request)
    {
        _request = request;
    }

    /// <inheritdoc />
    public async Task<PokemonsGetResponse> HandleAsync()
    {
        try
        {
            var result = new List<PokemonGetResponseItem>();
            var client = new HttpClient();

            var offset = _request.Page is 0 or null
                ? 0
                : _request.PageSize * (_request.Page - 1);

            var limit = _request.PageSize is 0 or null
                ? 10
                : _request.PageSize;
            
            GetPokemonsModel pokemons = 
                await client
                    .GetFromJsonAsync<GetPokemonsModel>($"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit={limit}")
                ?? throw new Exception("Не удалось найти покемонов");

            foreach (var pokemonItem in pokemons.Results)
            {
                var pokemon = await client.GetFromJsonAsync<Pokemon>(pokemonItem.Url)
                    ?? throw new Exception("Не удалось найти покемона");
                
                result.Add(new PokemonGetResponseItem
                {
                    Id = pokemon.Id,
                    Name = pokemon.Name,
                    Weight = pokemon.Weight,
                    Height = pokemon.Height,
                    Image = pokemon.Sprites.FrontDefault
                });
            }
            
            return new PokemonsGetResponse(pokemons.Count)
            {
                Items = result
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}