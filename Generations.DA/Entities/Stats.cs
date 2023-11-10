using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities
{
    public class Stats
    {
        [Key]
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }
    }
}
