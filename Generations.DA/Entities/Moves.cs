using Generations.PokemonManager.Models;
using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities
{
    public class Moves
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int PowerPoints { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<Pokemons> Pokemons { get; set; } = new();

        public static Move ConvertMoveEntity(Moves MoveEntity)
        {
            Move move = new()
            {
                Id = MoveEntity.Id,
                Name = MoveEntity.Name,
                Description = MoveEntity.Description,
                Type = MoveEntity.Type,
                PowerPoints = MoveEntity.PowerPoints,
                Power = MoveEntity.Power,
                Accuracy = MoveEntity.Accuracy,
                Category = MoveEntity.Category,
            };

            return move;
        }
    }
}
