using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities
{
    public class Pokemons
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string? SecondType { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public List<Stats> Stats { get; set; } = new();
        public List<Moves> Moves { get; set; } = new();
    }
}
