using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.API.DTOs
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sprite { get; set; } = string.Empty;

        public ItemDTO(ItemModel item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Sprite = item.Sprite;
        }
    }
}
