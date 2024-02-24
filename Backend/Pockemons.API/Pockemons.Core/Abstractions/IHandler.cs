using Pockemons.Contracts.Abstractions;

namespace Pockemons.Core.Abstractions;

/// <summary>
/// Обработчик запроса
/// </summary>
public interface IHandler<TResponse> where TResponse: IResponse
{
    /// <summary>
    /// Обработать запрос
    /// </summary>
    /// <returns>Ответ</returns>
    public Task<TResponse> HandleAsync();
}