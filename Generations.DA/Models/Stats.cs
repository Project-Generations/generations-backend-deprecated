using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Models
{
    public class Stats
    {
        [Key]
        public int Id { get; set; }
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseSpecialDefense { get; set; }
        public int BaseSpeed { get; set; }
    }
}
