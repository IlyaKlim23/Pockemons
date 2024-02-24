using Pockemons.Contracts.Abstractions;

namespace Pockemons.Contracts.Requests.Pockemons.GetBy;

/// <summary>
/// Ответ на <see cref="PockemonsGetByRequest"/>
/// </summary>
public class PockemonsGetByResponse: IResponse
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