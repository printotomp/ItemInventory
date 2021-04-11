using ShopBridgeWebAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeWebAPICore.IServices
{
    public interface IItemService
    {
        public Task<IEnumerable<Item>> GetItem();

        public Task<List<Item>> GetItemById(int id);

        public Task<Item> AddItem(Item Item);

        public Task<Item> UpdateItem(Item Item);

        public Task<Item> DeleteItem(int id);
    }
}
