using Pockemons.Contracts.Requests.Pockemons.GetBy;
using Pockemons.Core.Abstractions;

namespace Pockemons.Core.Requests.Pockemons.GetBy;

/// <inheritdoc />
public class PockemonsGetByHandler: IHandler<PockemonsGetByResponse>
{
    private readonly PockemonsGetByRequest _request;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="request">Запрос</param>
    public PockemonsGetByHandler(PockemonsGetByRequest request)
    {
        _request = request;
    }
    
    /// <inheritdoc />
    public async Task<PockemonsGetByResponse> HandleAsync()
    {
        return new PockemonsGetByResponse
        {
            Id = 12,
            Name = ""
        };
    }
}