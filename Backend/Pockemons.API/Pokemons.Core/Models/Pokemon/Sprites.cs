using System.Text.Json.Serialization;

namespace Pockemons.Core.Models.Pockemon;

public class Sprites
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = default!;
}