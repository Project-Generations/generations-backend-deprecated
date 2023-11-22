using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.API.DTOs
{
    public class ItemByIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;
        public bool IsHeldItem { get; set; }

        public ItemByIdDTO(ItemModel item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Description = item.Description;
            this.Sprite = item.Sprite;
            this.IsHeldItem = item.IsHeldItem;
        }
    }
}
