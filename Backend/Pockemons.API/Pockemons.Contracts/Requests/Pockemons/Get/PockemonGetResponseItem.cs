namespace Pockemons.Contracts.Requests.Pockemons.Get;

/// <summary>
/// Модель покемона
/// </summary>
public class PockemonGetResponseItem
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = default!;
}