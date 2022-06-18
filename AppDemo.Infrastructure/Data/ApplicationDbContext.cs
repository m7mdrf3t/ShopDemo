using AppDemo.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace AppDemo.Infrastructure.Data;
public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Cart> Carts { get; set; } = null!;
}

