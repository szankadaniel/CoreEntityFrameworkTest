using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CoreEntityFrameworkTest.DAL
{

    public class CatalogContext : DbContext
    {

        public CatalogContext()
        {

        }

        public DbSet<CatalogItem> CatalogItems { get; set; }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }

        public DbSet<CatalogType> CatalogTypes { get; set; }

        public DbSet<CatalogBasket> CatalogBaskets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=Catalogs;Username=postgres;Password=123456");
        }

    }

    //public class BasePSqlDbContext : DbContext
    //{

    //    public BasePSqlDbContext()
    //    {

    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseNpgsql(@"Host=localhost;Database=Catalogs;Username=postgres;Password=123456");
    //    }

    //}

}