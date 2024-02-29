using System.Net.Http.Json;
using Pockemons.Contracts.Requests.Pockemons.GetBy;
using Pockemons.Core.Abstractions;
using Pockemons.Core.Entities;

namespace Pockemons.Core.Requests.Pokemons.GetBy;

/// <inheritdoc />
public class PokemonsGetByHandler: IHandler<PokemonsGetByResponse>
{
    private readonly PokemonsGetByRequest _request;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="request">Запрос</param>
    public PokemonsGetByHandler(PokemonsGetByRequest request)
    {
        _request = request;
    }
    
    /// <inheritdoc />
    public async Task<PokemonsGetByResponse> HandleAsync()
    {
        var client = new HttpClient();

        var filterParam = _request.Id == null
            ? _request.Name
            : _request.Id.ToString();
        
        Pokemon pokemon = 
            await client
                .GetFromJsonAsync<Pokemon>($"https://pokeapi.co/api/v2/pokemon/{filterParam}")
            ?? throw new Exception("Не удалось найти покемона");

        return new PokemonsGetByResponse
        {
            Id = pokemon.Id,
            Name = pokemon.Name,
            Image = pokemon.Sprites.FrontDefault,
            Weight = pokemon.Weight,
            Height = pokemon.Height
        };
    }
}