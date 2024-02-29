using Microsoft.AspNetCore.Mvc;
using Pockemons.Contracts.Requests.Pockemons.Get;
using Pockemons.Contracts.Requests.Pockemons.GetBy;
using Pockemons.Core.Requests.Pokemons.Get;
using Pockemons.Core.Requests.Pokemons.GetBy;

namespace Pockemons.API.Controllers;

/// <summary>
/// Контроллер сущности "Покемон"
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class PokemonController: ControllerBase
{
    /// <summary>
    /// Получить список сущностей по фильтру
    /// </summary>
    /// <param name="request">Запрос</param>
    /// <returns>Список сущностей</returns>
    [HttpGet("/pockemons")]
    public async Task<PokemonsGetResponse> GetAll(
        [FromQuery] PokemonsGetRequest request)
    {
        var handler = new PokemonsGetHandler(request);
        return await handler.HandleAsync();
    }

    /// <summary>
    /// Получить по свойству
    /// </summary>
    /// <param name="request">Запрос</param>
    /// <returns>Сущность</returns>
    [HttpGet("/pockemon")]
    public async Task<PokemonsGetByResponse> GetBy(
        [FromQuery] PokemonsGetByRequest request)
    {
        var handler = new PokemonsGetByHandler(request);
        return await handler.HandleAsync();
    }
}