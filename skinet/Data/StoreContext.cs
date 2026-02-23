using Microsoft.EntityFrameworkCore;
using skinet.Models.Entities;

namespace skinet.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
