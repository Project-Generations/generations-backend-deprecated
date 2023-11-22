using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.ItemManager.Interfaces
{
    public interface iItemService
    {
        public List<ItemModel> GetItems();
        public ItemModel GetItemById(int id);
    }
}
