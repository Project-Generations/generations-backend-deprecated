using Generations.PokemonManager.Models;
using System.ComponentModel.DataAnnotations;
using StatEntity = Generations.DA.Entities.Stats;

namespace Generations.DA.Entities
{
    public class Stats
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }

        public static Stat ConvertStatEntity(StatEntity statEntity)
        {
            Stat stat = new()
            {
                Name = statEntity.Name,
                Value = statEntity.Value
            };

            return stat;
        }
    }
}
