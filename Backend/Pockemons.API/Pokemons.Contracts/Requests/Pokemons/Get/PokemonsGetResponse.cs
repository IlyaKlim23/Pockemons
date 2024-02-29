using Pockemons.Contracts.Abstractions;

namespace Pockemons.Contracts.Requests.Pockemons.Get;

/// <summary>
/// Ответ на <see cref="PokemonsGetRequest"/>
/// </summary>
public class PokemonsGetResponse: IResponse
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="totalCount">Кол-во записей</param>
    public PokemonsGetResponse(int totalCount)
    {
        TotalCount = totalCount;
    }

    /// <summary>
    /// Кол-во записей
    /// </summary>
    public int TotalCount { get; set; }
    
    /// <summary>
    /// Покемоны
    /// </summary>
    public List<PokemonGetResponseItem> Items { get; set; } = default!;
}