using Generations.PokemonManager.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using MoveEntity = Generations.DA.Entities.Moves;
using PokemonEntity = Generations.DA.Entities.Pokemons;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;


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
                    PokemonEntity getPokemon = dataContext.Pokemons.Include(s => s.Stats).Include(m => m.Moves).Single(poke => poke.Id == id);

                    PokemonModel pokemon = new()
                    {
                        Id = getPokemon.Id,
                        Name = getPokemon.Name,
                        Sprite = getPokemon.Sprite,
                        Type = getPokemon.Type,
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
                    var _pokemons = dataContext.Pokemons.ToList();
                    List<PokemonModel> pokemons = new();

                    foreach (var _pokemon in _pokemons)
                    {
                        PokemonModel pokemon = new()
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
