using Generations.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Pokemon.BL.Interfaces;

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
                List<Pokemon.BL.Entities.Pokemon> pokemons = iPokemonService.GetPokemons();

                foreach (Pokemon.BL.Entities.Pokemon pokemon in pokemons)
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
    }
}
