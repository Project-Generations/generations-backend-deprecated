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

        public Entities.Pokemon GetPokemonById(int id)
        {
            try
            {
                Pokemon.BL.Entities.Pokemon pokemon = iPokemon.GetPokemonById(id);
                return pokemon;
            }
            catch (Exception)
            {
                throw;
            }
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
