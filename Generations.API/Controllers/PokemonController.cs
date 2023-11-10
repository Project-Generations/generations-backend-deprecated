using Generations.API.DTOs;
using Generations.PokemonManager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PokemonModel = Generations.PokemonManager.Models.Pokemon;

namespace Generations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        readonly iPokemonService iPokemonService;

        public PokemonController(iPokemonService iPokemonService)
        {
            this.iPokemonService = iPokemonService;
        }


        [HttpGet("")]
        public List<PokemonDTO> Get()
        {
            List<PokemonDTO> pokemonDTOs = new();

            try
            {
                List<PokemonModel> pokemons = iPokemonService.GetPokemons();

                foreach (PokemonModel pokemon in pokemons)
                {
                    PokemonDTO pokemonDTO = new(pokemon);
                    pokemonDTOs.Add(pokemonDTO);
                }

                return pokemonDTOs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public PokemonByIdDTO Get(int id)
        {
            try
            {
                PokemonModel pokemon = iPokemonService.GetPokemonById(id);

                PokemonByIdDTO pokemonByIdDTO = new(pokemon);

                return pokemonByIdDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
