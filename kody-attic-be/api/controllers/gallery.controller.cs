using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using KodyAtticBE.Models;

namespace KodyAtticBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        // For testing prior to SQL DB intergration

        // private static readonly List<Item> items = new List<Item>
        // {
        //     new() { Id = 1, Name = "Item 1", Price = 9.99M, Description = "Description of Item 1", ImageUrl = "http://example.com/image.jpg", Year = "1970-1980", Color = "Blue", Available = 1 },
        //     new() { Id = 2, Name = "Item 2", Price = 9.99M, Description = "Description of Item 2", ImageUrl = "http://example.com/image.jpg", Year = "1970-1980", Color = "Black", Available = 1 },
        //     new() { Id = 3, Name = "Item 3", Price = 9.99M, Description = "Description of Item 3", ImageUrl = "http://example.com/image.jpg", Year = "1970-1980", Color = "Green", Available = 0 },

        // };

        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public IEnumerable<Item> Get()
        // {
        //     return items;
        // }
        // [HttpGet("{id}")]
        // public IActionResult GetItemById(int id)
        // {
        //     var item = items.FirstOrDefault(i => i.Id == id);
        //     if (item == null)
        //     {
        //         return NotFound(); // Returns a 404 response if the item is not found
        //     }
        //     return Ok(item); // Returns a 200 response with the item
        // }

        [HttpGet] // get all objects for gallery from db
        public async Task<ActionResult<IEnumerable<Item>>> Get()
        {
            return await _context.Items.ToListAsync();
        }

        [HttpGet("{id}")] // get one object for gallery from db by specified id
        public async Task<ActionResult<Item>> GetItemById(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}