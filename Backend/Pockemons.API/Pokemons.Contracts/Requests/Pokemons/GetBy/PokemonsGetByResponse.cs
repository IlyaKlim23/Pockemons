using Pockemons.Contracts.Abstractions;

namespace Pockemons.Contracts.Requests.Pockemons.GetBy;

/// <summary>
/// Ответ на <see cref="PokemonsGetByRequest"/>
/// </summary>
public class PokemonsGetByResponse: IResponse
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