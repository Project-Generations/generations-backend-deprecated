using Pokemon.BL.Interfaces;
using PokemonModel = Pokemon.BL.Models.Pokemon;

namespace Pokemon.BL.Services
{
    public class PokemonService : iPokemonService
    {
        private iPokemon iPokemon;

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
