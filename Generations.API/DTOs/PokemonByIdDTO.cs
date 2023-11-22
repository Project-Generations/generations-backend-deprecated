using Generations.PokemonManager.Models;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;
using TypeModel = Generations.TypeManager.Models.Type;

namespace Generations.API.DTOs
{
    public class PokemonByIdDTO
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public List<TypeModel> Types { get; set; } = new();
        public List<Ability> Abilities { get; set; }
        public List<Move> Moves { get; set; }

        //Base Stats
        public List<Stat> Stats { get; set; } = new();

        public PokemonByIdDTO(PokemonModel pokemon)
        {
            this.PokemonId = pokemon.Id;
            this.Name = pokemon.Name;
            this.Types = pokemon.Types;
            this.Sprite = pokemon.Sprite;
            this.Abilities = pokemon.Abilities;
            this.Moves = pokemon.Moves;
            this.Stats = pokemon.Stats;
        }
    }
}
