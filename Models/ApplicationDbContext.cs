using Microsoft.EntityFrameworkCore;

namespace UserApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        //[Finished]one product has multiple stores, (multiple products are owned by Seniors(not confirmed))
        public DbSet<Product> Products { get; set; }

        //[Finished] a store can be used by multiple products
        public DbSet<Store> Stores { get; set; }

        public DbSet<Image> Images { get; set; }
    }
}
