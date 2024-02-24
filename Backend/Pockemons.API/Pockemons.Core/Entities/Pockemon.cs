using Pockemons.Core.Abstractions;

namespace Pockemons.Core.Entities;

/// <summary>
/// Покемон
/// </summary>
public class Pockemon: BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
}