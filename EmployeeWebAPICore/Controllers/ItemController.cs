using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopBridgeWebAPICore.DTO;
using ShopBridgeWebAPICore.IServices;
using ShopBridgeWebAPICore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridgeWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IItemService _ItemService;
        public ItemController(IItemService Item, IMapper mapper)
        {
            _ItemService = Item;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<Item>> GetItems()
        {
            return await _ItemService.GetItem();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetItemId(int id)
        {
            var item = await _ItemService.GetItemById(id);
            var Item = _mapper.Map<List<ItemDTO>>(item);
            return Ok(Item);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddItem(Item Item)
        {
            var item = await _ItemService.AddItem(Item);
            var Iteme = _mapper.Map<ItemDTO>(item);
            return Ok(Iteme);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> EditItem(ItemDTO itemDTO)
        {
            return Ok(await _ItemService.UpdateItem(_mapper.Map<Item>(itemDTO)));
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = _ItemService.DeleteItem(id);
            return Ok(await item);
        }
    }
}
