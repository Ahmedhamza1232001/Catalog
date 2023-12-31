using Catalog.Models;

namespace Catalog.Repositories;

public class InMemItemsRepository
{
    private readonly List<Item> items = new()
    {
        new Item {Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.Now},
        new Item {Id = Guid.NewGuid(), Name = "Iron sword", Price = 20, CreatedDate = DateTimeOffset.Now},
        new Item {Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 9, CreatedDate = DateTimeOffset.Now},
    };

    public IEnumerable<Item> GetItems()
    {
        return items;
    }
    public Item GetItem(Guid id)
    {
        return items.Where(item => item.Id == id).SingleOrDefault();
    }
}