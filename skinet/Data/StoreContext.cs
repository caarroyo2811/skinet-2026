using Microsoft.EntityFrameworkCore;
using skinet.Models;

namespace skinet.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
