using Generations.PokemonManager.Models;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;

namespace Generations.API.DTOs
{
    public class PokemonByIdDTO
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public List<Move> Moves { get; set; }

        //Base Stats
        public List<Stat> Stats { get; set; } = new();

        public PokemonByIdDTO(PokemonModel pokemon)
        {
            this.PokemonId = pokemon.Id;
            this.Name = pokemon.Name;
            this.Type = pokemon.Type;
            this.Sprite = pokemon.Sprite;
            this.Stats = pokemon.Stats;
            this.Moves = pokemon.Moves;
        }
    }
}
