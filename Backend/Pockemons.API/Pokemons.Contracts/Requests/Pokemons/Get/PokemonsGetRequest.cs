namespace Pockemons.Contracts.Requests.Pockemons.Get;

/// <summary>
/// Запрос на получение списка сущностей "Покемон"
/// </summary>
public class PokemonsGetRequest
{
    /// <summary>
    /// Размер страницы
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Номер страницы
    /// </summary>
    public int? Page { get; set; }
}