namespace Generations.DA.Models
{
    public class CreatedPokemon : Pokemon
    {
        public int CreatedPokemonId { get; set; }
        public int UserId { get; set; }
        public int Level { get; set; }
        public string Nature { get; set; } = string.Empty;
        public Item HeldItem { get; set; }

        public Move Move1 { get; set; }
        public Move Move2 { get; set; }
        public Move Move3 { get; set; }
        public Move Move4 { get; set; }


        public int HpEv { get; set; }
        public int AttackEv { get; set; }
        public int DefenseEv { get; set; }
        public int SpecialAttackEv { get; set; }
        public int SpecialDefenseEv { get; set; }
        public int SpeedEv { get; set; }

        public int HpIv { get; set; }
        public int AttackIv { get; set; }
        public int DefenseIv { get; set; }
        public int SpecialAttackIv { get; set; }
        public int SpecialDefenseIv { get; set; }
        public int SpeedIv { get; set; }
    }
}
