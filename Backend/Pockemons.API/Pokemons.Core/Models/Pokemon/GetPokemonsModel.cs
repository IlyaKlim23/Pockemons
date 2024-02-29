namespace Pockemons.Core.Models.Pokemon
{
    public class GetPokemonsModel
    {
        public int Count { get; set; }

        public string Next { get; set; } = default!;

        public string Previous { get; set; } = default!;

        public List<PokemonItem> Results { get; set; } = default!;
    }

    public class PokemonItem
    {
        public string Name { get; set; } = default!;

        public string Url { get; set; } = default!;
    }
}