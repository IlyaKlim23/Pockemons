using Pockemons.Contracts.Requests.Pockemons.Get;
using Pockemons.Core.Abstractions;

namespace Pockemons.Core.Requests.Pockemons.Get;

/// <inheritdoc />
public class PockemonsGetHandler: IHandler<PockemonsGetResponse>
{
    private readonly PockemonsGetRequest _request;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="request">Запрос</param>
    public PockemonsGetHandler(
        PockemonsGetRequest request)
    {
        _request = request;
    }

    /// <inheritdoc />
    public async Task<PockemonsGetResponse> HandleAsync()
    {
        var item = new PockemonGetResponseItem
        {
            Id = 1,
            Name = "namememe"
        };
        
        return new PockemonsGetResponse
        {
            Items = new List<PockemonGetResponseItem>{item}
        };
    }
}