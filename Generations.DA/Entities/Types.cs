using System.ComponentModel.DataAnnotations;
using TypeEntity = Generations.DA.Entities.Types;
using TypeModel = Generations.TypeManager.Models.Type;

namespace Generations.DA.Entities
{
    public class Types
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Pokemons> Pokemons { get; set; } = new();

        public static TypeModel ConvertTypeEntity(TypeEntity typeEntity)
        {
            TypeModel type = new()
            {
                Id = typeEntity.Id,
                Name = typeEntity.Name,
            };

            return type;
        }
    }
}
