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

        public DbSet<NewTestTable> NewTestTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* If we configure the relation here manually, then the foreign key property is not required. */
            modelBuilder.Entity<Product>()
                .HasOne(p => p.CatalogBaskets)
                .WithMany(b => b.Products);

            /* Single navigation property */
            modelBuilder.Entity<CatalogItem>()
                .HasOne(ci => ci.CatalogType);

            modelBuilder.Entity<NewTestTable>().HasData(
                new NewTestTable() { TestEnum = MyTestEnum.ENUM_THREE, NewTestTableId = 1, Code = "ASDF", Name = "sdf" },
                new NewTestTable() { TestEnum = MyTestEnum.ENUM_ONE, NewTestTableId = 2, Code = "ASDF2", Name = "sdf2" },
                new NewTestTable() { TestEnum = MyTestEnum.ENUM_TWO, NewTestTableId = 3, Code = "ASDF3", Name = "sdf3" },
                new NewTestTable() { TestEnum = MyTestEnum.ENUM_TWO, NewTestTableId = 4, Code = "ASDF4", Name = "sdf4" },
                new NewTestTable() { TestEnum = MyTestEnum.ENUM_ONE, NewTestTableId = 5, Code = "ASDF5", Name = "sdf5" }
                );

        }

    }

}