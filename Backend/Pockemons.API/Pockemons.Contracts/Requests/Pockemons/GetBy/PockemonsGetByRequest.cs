namespace Pockemons.Contracts.Requests.Pockemons.GetBy;

/// <summary>
/// Запрос на получение сущности "Покемон"
/// </summary>
public class PockemonsGetByRequest
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string? Name { get; set; }
}