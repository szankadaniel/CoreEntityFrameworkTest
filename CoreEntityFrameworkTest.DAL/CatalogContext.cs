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

        //public DbSet<CatalogBrandsAndCatalogItems> CatalogBrandsAndCatalogItems { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CatalogBrandsAndCatalogItems>().HasNoKey();
        //    base.OnModelCreating(modelBuilder);
        //}

    }

}