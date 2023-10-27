namespace Generations.API.DTOs
{
    public class PokemonDTO
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;

        public PokemonDTO(Pokemon.BL.Entities.Pokemon pokemon)
        {
            this.PokemonId = pokemon.Id;
            this.Name = pokemon.Name;
            this.Sprite = pokemon.Sprite;
        }
    }
}
