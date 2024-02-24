using Microsoft.AspNetCore.Mvc;
using Pockemons.Contracts.Requests.Pockemons.Get;
using Pockemons.Contracts.Requests.Pockemons.GetBy;
using Pockemons.Core.Requests.Pockemons.Get;
using Pockemons.Core.Requests.Pockemons.GetBy;

namespace Pockemons.API.Controllers;

/// <summary>
/// Контроллер сущности "Покемон"
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class PockemonController: ControllerBase
{
    /// <summary>
    /// Получить список сущностей по фильтру
    /// </summary>
    /// <param name="request">Запрос</param>
    /// <returns>Список сущностей</returns>
    [HttpGet("/pockemons")]
    public async Task<PockemonsGetResponse> GetAll(
        [FromQuery] PockemonsGetRequest request)
    {
        var handler = new PockemonsGetHandler(request);
        return await handler.HandleAsync();
    }

    /// <summary>
    /// Получить по свойству
    /// </summary>
    /// <param name="request">Запрос</param>
    /// <returns>Сущность</returns>
    [HttpGet("/pockemon")]
    public async Task<PockemonsGetByResponse> GetBy(
        [FromQuery] PockemonsGetByRequest request)
    {
        var handler = new PockemonsGetByHandler(request);
        return await handler.HandleAsync();
    }
}