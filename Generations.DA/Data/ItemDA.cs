using Generations.ItemManager.Interfaces;
using MySqlConnector;
using ItemEntity = Generations.DA.Entities.Items;
using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.DA.Data
{
    public class ItemDA : iItem
    {
        private readonly DataContext dataContext;

        public ItemDA(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public ItemModel GetItemById(int id)
        {
            using (dataContext)
            {
                try
                {
                    ItemEntity getItem = dataContext.Items.Single(item => item.Id == id);

                    ItemModel item = new()
                    {
                        Id = getItem.Id,
                        Name = getItem.Name,
                        Description = getItem.Description,
                        Sprite = getItem.Sprite,
                        IsHeldItem = getItem.IsHeldItem,
                    };

                    return item;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }

        public List<ItemModel> GetItems()
        {
            using (dataContext)
            {
                try
                {
                    var _items = dataContext.Items.ToList();
                    List<ItemModel> items = new();

                    foreach (var _item in _items)
                    {
                        ItemModel item = new()
                        {
                            Id = _item.Id,
                            Name = _item.Name,
                            Sprite = _item.Sprite,
                        };

                        items.Add(item);
                    }

                    return items;
                }
                catch (MySqlException exception)
                {
                    throw exception;
                }
            }
        }
    }
}
