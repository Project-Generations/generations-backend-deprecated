using PokemonModel = Generations.PokemonManager.Models.Pokemon;

namespace Generations.PokemonManager.Interfaces
{
    public interface iPokemon
    {
        public List<PokemonModel> GetPokemons();
        public PokemonModel GetPokemonById(int id);
    }
}
