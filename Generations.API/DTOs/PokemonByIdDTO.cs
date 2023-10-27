namespace Generations.API.DTOs
{
    public class PokemonByIdDTO
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;

        //Base Stats
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseSpecialDefense { get; set; }
        public int BaseSpeed { get; set; }

        public PokemonByIdDTO(Pokemon.BL.Entities.Pokemon pokemon)
        {
            this.PokemonId = pokemon.Id;
            this.Name = pokemon.Name;
            this.Type = pokemon.Type;
            this.Sprite = pokemon.Sprite;
            this.BaseHp = pokemon.BaseHp;
            this.BaseAttack = pokemon.BaseAttack;
            this.BaseDefense = pokemon.BaseDefense;
            this.BaseSpecialAttack = pokemon.BaseSpecialAttack;
            this.BaseSpecialDefense = pokemon.BaseSpecialDefense;
            this.BaseSpeed = pokemon.BaseSpeed;
        }
    }
}
