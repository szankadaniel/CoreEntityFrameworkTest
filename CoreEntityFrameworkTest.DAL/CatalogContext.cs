using Microsoft.EntityFrameworkCore;

namespace CoreEntityFrameworkTest.DAL
{

    public class CatalogContext : DbContext
    {

        public CatalogContext()
            : base(new DbContextOptionsBuilder().UseNpgsql(Config.GetConnectionString("CatalogDb")).Options)
        {
        }

        public DbSet<CatalogItem> CatalogItems { get; set; }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }

        public DbSet<CatalogType> CatalogTypes { get; set; }

        public DbSet<CatalogBasket> CatalogBaskets { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* If we configure the relation here manually, then the foreign key property is not required. */
            modelBuilder.Entity<Product>()
                .HasOne(p => p.CatalogBaskets)
                .WithMany(b => b.Products);

            /* Single navigation property */
            modelBuilder.Entity<CatalogItem>()
                .HasOne(ci => ci.CatalogType);
        }

    }

}