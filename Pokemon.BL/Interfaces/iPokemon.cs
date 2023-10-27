namespace Pokemon.BL.Interfaces
{
    public interface iPokemon
    {
        public List<Pokemon.BL.Entities.Pokemon> GetPokemons();
        public Pokemon.BL.Entities.Pokemon GetPokemonById(int id);
    }
}
