using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using KodyAtticBE.Models;

namespace KodyAtticBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

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