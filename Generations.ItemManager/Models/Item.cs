namespace Generations.ItemManager.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public bool IsHeldItem { get; set; }
    }
}
