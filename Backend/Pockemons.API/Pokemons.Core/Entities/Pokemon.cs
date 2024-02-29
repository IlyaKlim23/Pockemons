using Pockemons.Core.Abstractions;
using Pockemons.Core.Models.Pockemon;

namespace Pockemons.Core.Entities;

/// <summary>
/// Покемон
/// </summary>
public class Pokemon: BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = default!;
    
    /// <summary>
    /// Вес
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// Рост
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Спрайты
    /// </summary>
    public Sprites Sprites { get; set; } = default!;
}