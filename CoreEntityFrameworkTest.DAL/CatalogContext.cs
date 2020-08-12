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

    }

}