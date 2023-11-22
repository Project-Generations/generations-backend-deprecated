using Generations.PokemonManager.Models;
using System.ComponentModel.DataAnnotations;
using AbilityEntity = Generations.DA.Entities.Abilities;

namespace Generations.DA.Entities
{
    public class Abilities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsHiddenAbility { get; set; }
        public List<Pokemons> Pokemons { get; set; } = new();

        public static Ability ConvertAbilityEntity(AbilityEntity abilityEntity)
        {
            Ability ability = new()
            {
                Id = abilityEntity.Id,
                Name = abilityEntity.Name,
                Description = abilityEntity.Description,
                IsHiddenAbility = abilityEntity.IsHiddenAbility,
            };

            return ability;
        }
    }
}
