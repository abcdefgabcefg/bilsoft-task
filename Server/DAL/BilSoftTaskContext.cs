using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class BilSoftTaskContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public BilSoftTaskContext(DbContextOptions<BilSoftTaskContext> options): base(options) { }
    }
}
