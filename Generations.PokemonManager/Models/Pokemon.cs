using TypeModel = Generations.TypeManager.Models.Type;

namespace Generations.PokemonManager.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public List<TypeModel> Types { get; set; } = new();
        public List<Ability> Abilities { get; set; } = new();
        public List<Move> Moves { get; set; } = new();

        //Base Stats
        public List<Stat> Stats { get; set; } = new();
    }
}