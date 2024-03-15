using Microsoft.EntityFrameworkCore;
using KodyAtticBE.Models; // Adjust the namespace to where your models are

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
}
