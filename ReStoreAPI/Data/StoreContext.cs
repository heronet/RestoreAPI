using Microsoft.EntityFrameworkCore;
using ReStoreAPI.Models;

namespace ReStoreAPI.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
}
