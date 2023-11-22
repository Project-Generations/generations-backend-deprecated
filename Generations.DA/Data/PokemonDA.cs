using Generations.PokemonManager.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using AbilityEntity = Generations.DA.Entities.Abilities;
using MoveEntity = Generations.DA.Entities.Moves;
using PokemonEntity = Generations.DA.Entities.Pokemons;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;
using StatEntity = Generations.DA.Entities.Stats;
using TypeEntity = Generations.DA.Entities.Types;


namespace Generations.DA.Data
{
    public class PokemonDA : iPokemon
    {
        private readonly DataContext dataContext;

        public PokemonDA(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public PokemonModel GetPokemonById(int id)
        {
            using (dataContext)
            {
                try
                {
                    PokemonEntity getPokemon = dataContext.Pokemons
                        .Include(t => t.Types)
                        .Include(a => a.Abilities)
                        .Include(s => s.Stats)
                        .Include(m => m.Moves)
                        .Single(poke => poke.Id == id);

                    PokemonModel pokemon = new()
                    {
                        Id = getPokemon.Id,
                        Name = getPokemon.Name,
                        Sprite = getPokemon.Sprite,
                        Types = getPokemon.Types.Select(TypeEntity.ConvertTypeEntity).ToList(),
                        Abilities = getPokemon.Abilities.Select(AbilityEntity.ConvertAbilityEntity).ToList(),
                        Stats = getPokemon.Stats.Select(StatEntity.ConvertStatEntity).ToList(),
                        Moves = getPokemon.Moves.Select(MoveEntity.ConvertMoveEntity).ToList(),
                    };

                    return pokemon;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }

        public List<PokemonModel> GetPokemons()
        {
            using (dataContext)
            {
                try
                {
                    var _pokemons = dataContext.Pokemons.Include(t => t.Types).ToList();
                    List<PokemonModel> pokemons = new();

                    foreach (var _pokemon in _pokemons)
                    {
                        PokemonModel pokemon = new()
                        {
                            Id = _pokemon.Id,
                            Name = _pokemon.Name,
                            Sprite = _pokemon.Sprite,
                            Types = _pokemon.Types.Select(TypeEntity.ConvertTypeEntity).ToList(),
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
