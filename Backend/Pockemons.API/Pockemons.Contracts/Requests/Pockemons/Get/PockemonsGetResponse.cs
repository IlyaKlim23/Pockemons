using Pockemons.Contracts.Abstractions;

namespace Pockemons.Contracts.Requests.Pockemons.Get;

/// <summary>
/// Ответ на <see cref="PockemonsGetRequest"/>
/// </summary>
public class PockemonsGetResponse: IResponse
{
    /// <summary>
    /// Покемоны
    /// </summary>
    public List<PockemonGetResponseItem> Items { get; set; } = default!;
}