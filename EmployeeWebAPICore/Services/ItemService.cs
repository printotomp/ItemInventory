using ShopBridgeWebAPICore.IServices;
using ShopBridgeWebAPICore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeWebAPICore.Services
{
    public class ItemService : IItemService
    {
        APICoreDBContext dbContext;
        public ItemService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public async Task<IEnumerable<Item>> GetItem()
        {
            var item = dbContext.Item.ToList();
            return item;
        }

        public async Task<List<Item>> GetItemById(int id)
        {
            return await dbContext.Item.Where(x => x.Id == id).ToListAsync();
        }

        public async Task<Item> AddItem(Item Item)
        {
            if (Item != null)
            {
                dbContext.Item.Add(Item);
                dbContext.SaveChanges();
                return Item;
            }
            return null;
        }

        public async Task<Item> UpdateItem(Item Item)
        {
            dbContext.Entry(Item).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Item;
        }

        public async Task<Item> DeleteItem(int id)
        {
            var Item = await dbContext.Item.FirstOrDefaultAsync(x => x.Id == id);
            dbContext.Entry(Item).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Item;
        }
    }
}