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

        public Pokemon.BL.Entities.Pokemon GetPokemonById(int id)
        {
            using (dataContext)
            {
                try
                {
                    Generations.DA.Models.Pokemons getPokemon = dataContext.Pokemons.Single(poke => poke.Id == id);
                    Generations.DA.Models.Stats getStatsFromPokemon = dataContext.Stats.Single(poke => poke.Id == id);

                    Pokemon.BL.Entities.Pokemon pokemon = new()
                    {
                        Id = getPokemon.Id,
                        Name = getPokemon.Name,
                        Sprite = getPokemon.Sprite,
                        Type = getPokemon.Type,
                        BaseHp = getStatsFromPokemon.BaseHp,
                        BaseAttack = getStatsFromPokemon.BaseAttack,
                        BaseDefense = getStatsFromPokemon.BaseDefense,
                        BaseSpecialAttack = getStatsFromPokemon.BaseSpecialAttack,
                        BaseSpecialDefense = getStatsFromPokemon.BaseSpecialDefense,
                        BaseSpeed = getStatsFromPokemon.BaseSpeed,
                    };

                    return pokemon;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
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
                        Pokemon.BL.Entities.Pokemon pokemon = new()
                        {
                            Id = _pokemon.Id,
                            Name = _pokemon.Name,
                            Sprite = _pokemon.Sprite,
                        };

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
