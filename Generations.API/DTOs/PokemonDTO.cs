namespace Generations.API.DTOs
{
    public class PokemonDTO
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public int[] Stats = new int[6];

        public PokemonDTO(Pokemon.BL.Entities.Pokemon pokemon)
        {
            this.PokemonId = pokemon.PokemonId;
            this.Name = pokemon.Name;
            this.Type = pokemon.Type;
            this.Sprite = pokemon.Sprite;
            this.Stats = pokemon.Stats;
        }
    }
}
