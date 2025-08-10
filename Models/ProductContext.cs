using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    //inherit from base DbContext - performs all manipulation with ur DB
    public class ProductContext : DbContext
    {
        //list of product entity referred as DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //constructor - called during execution
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        //called during migration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-Q4LIC46;database=CodeFirst;integrated security=true;trustservercertificate=true;");
        }


    }
}
