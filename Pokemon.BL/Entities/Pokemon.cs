namespace Pokemon.BL.Entities
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public int[] Stats = new int[6];
    }
}
