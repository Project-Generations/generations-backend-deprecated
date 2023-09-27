using Pokemon.BL.Interfaces;

namespace Pokemon.BL.Services
{
    public class PokemonService : iPokemonService
    {
        private iPokemon iPokemon;

        public PokemonService(iPokemon iPokemon)
        {

            this.iPokemon = iPokemon;
        }

        public List<Entities.Pokemon> GetPokemons()
        {
            List<Entities.Pokemon> pokemons;

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
