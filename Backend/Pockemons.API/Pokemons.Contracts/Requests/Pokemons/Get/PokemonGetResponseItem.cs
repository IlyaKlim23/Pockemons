namespace Pockemons.Contracts.Requests.Pockemons.Get;

/// <summary>
/// Модель покемона
/// </summary>
public class PokemonGetResponseItem
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = default!;
    
    /// <summary>
    /// Изображение
    /// </summary>
    public string Image { get; set; } = default!;

    /// <summary>
    /// Вес
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// Рост
    /// </summary>
    public int Height { get; set; }
}