using MySqlConnector;
using Pokemon.BL.Interfaces;

namespace Generations.DA.Data
{
    public class PokemonDA : iPokemon
    {
        private readonly DataContext dataContext;

        public PokemonDA(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Pokemon.BL.Entities.Pokemon> GetPokemons()
        {
            using (dataContext)
            {
                try
                {
                    var _pokemons = dataContext.Pokemons.ToList();
                    List<Pokemon.BL.Entities.Pokemon> pokemons = new();

                    foreach (var _pokemon in _pokemons)
                    {
                        Pokemon.BL.Entities.Pokemon pokemon = new();

                        //Map data
                        pokemon.PokemonId = _pokemon.PokemonId;
                        pokemon.Name = _pokemon.Name;
                        pokemon.Sprite = _pokemon.Sprite;
                        pokemon.Type = _pokemon.Type;
                        pokemon.Stats[0] = _pokemon.BaseHp;
                        pokemon.Stats[1] = _pokemon.BaseAttack;
                        pokemon.Stats[2] = _pokemon.BaseDefense;
                        pokemon.Stats[3] = _pokemon.BaseSpecialAttack;
                        pokemon.Stats[4] = _pokemon.BaseSpecialDefense;
                        pokemon.Stats[5] = _pokemon.BaseSpeed;

                        pokemons.Add(pokemon);
                    }

                    return pokemons;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }
    }
}
