using Generations.ItemManager.Interfaces;
using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.ItemManager.Services
{
    public class ItemService : iItemService
    {
        private readonly iItem iItem;

        public ItemService(iItem iItem)
        {
            this.iItem = iItem;
        }

        public ItemModel GetItemById(int id)
        {
            try
            {
                ItemModel item = iItem.GetItemById(id);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ItemModel> GetItems()
        {
            List<ItemModel> items;

            try
            {
                items = iItem.GetItems();
            }
            catch (Exception)
            {
                throw;
            }

            return items;
        }
    }
}
