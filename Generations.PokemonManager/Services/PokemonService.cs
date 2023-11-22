using Generations.PokemonManager.Interfaces;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;

namespace Generations.PokemonManager.Services
{
    public class PokemonService : iPokemonService
    {
        private readonly iPokemon iPokemon;

        public PokemonService(iPokemon iPokemon)
        {
            this.iPokemon = iPokemon;
        }

        public PokemonModel GetPokemonById(int id)
        {
            try
            {
                PokemonModel pokemon = iPokemon.GetPokemonById(id);
                return pokemon;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PokemonModel> GetPokemons()
        {
            List<PokemonModel> pokemons;

            try
            {
                pokemons = iPokemon.GetPokemons();
            }
            catch (Exception)
            {
                throw;
            }

            return pokemons;
        }
    }
}
