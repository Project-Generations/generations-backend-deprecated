namespace Generations.PokemonManager.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;

        //Base Stats
        public List<Stat> Stats { get; set; } = new();
        public List<Move> Moves { get; set; } = new();
    }
}