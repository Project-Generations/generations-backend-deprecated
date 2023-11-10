namespace Generations.DA.Entities
{
    public class CreatedPokemons : Pokemons
    {
        public int CreatedPokemonId { get; set; }
        public int UserId { get; set; }
        public int Level { get; set; }
        public string Nature { get; set; } = string.Empty;
        public Items HeldItem { get; set; } = new();

        public Moves Move1 { get; set; } = new();
        public Moves Move2 { get; set; } = new();
        public Moves Move3 { get; set; } = new();
        public Moves Move4 { get; set; } = new();

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
