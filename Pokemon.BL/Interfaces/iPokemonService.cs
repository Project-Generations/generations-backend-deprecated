using PokemonModel = Generations.PokemonManager.Models.Pokemon;

namespace Pokemon.BL.Interfaces
{
    public interface iPokemonService
    {
        public List<PokemonModel> GetPokemons();
        public PokemonModel GetPokemonById(int id);
    }
}
