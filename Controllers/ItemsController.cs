using Catalog.Models;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace Catalog.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private readonly InMemItemsRepository repository;

    public ItemsController()
    {
        repository = new InMemItemsRepository();
    }
    [HttpGet]
    public IEnumerable<Item> GetItems()
    {
        var items = repository.GetItems();
        return items;
    }

    [HttpGet("{id}")]
    public ActionResult<Item> GetItem(Guid id)
    {
        var item = repository.GetItem(id);
        if(item is null)
            return NotFound();
        return item;
    }
}