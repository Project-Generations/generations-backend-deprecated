using Generations.API.DTOs;
using Generations.ItemManager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ItemModel = Generations.ItemManager.Models.Item;

namespace Generations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly iItemService iItemService;

        public ItemController(iItemService iItemService)
        {
            this.iItemService = iItemService;
        }

        [HttpGet("")]
        public List<ItemDTO> Get()
        {
            List<ItemDTO> itemDTOs = new();

            try
            {
                List<ItemModel> items = iItemService.GetItems();

                foreach (ItemModel item in items)
                {
                    ItemDTO itemDTO = new(item);
                    itemDTOs.Add(itemDTO);
                }

                return itemDTOs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public ItemByIdDTO Get(int id)
        {
            try
            {
                ItemModel item = iItemService.GetItemById(id);
                ItemByIdDTO itemByIdDTO = new(item);

                return itemByIdDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
