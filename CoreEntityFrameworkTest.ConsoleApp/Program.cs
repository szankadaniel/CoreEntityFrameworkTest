using CoreEntityFrameworkTest.DAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreEntityFrameworkTest.ConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CatalogContext catalogContext = new CatalogContext();

            /* CREATE */
            //CatalogBrand newBrand = new CatalogBrand() { Name = "Nev", Description = "Desc", Enabled = true };
            //catalogContext.CatalogBrands.Add(newBrand);
            //catalogContext.SaveChanges();

            /* UPDATE */
            //CatalogBrand brand = catalogContext.CatalogBrands.Find(3);
            //brand.Enabled = true;
            //catalogContext.SaveChanges();

            /* GET */
            /* Add the call to ToListAsync in order to execute the query immediately. Otherwise, the statement will assign an IQueryable<SelectListItem> to brandItems, which will not be executed until it is enumerated. */
            List<CatalogBrand> items = catalogContext.CatalogBrands
                .Where(b => b.Enabled == true)
                .ToList();

            /* CREATE THEN DELETE */
            //newBrand = new CatalogBrand() { Name = "delete", Description = "Desc", Enabled = true };
            //catalogContext.CatalogBrands.Add(newBrand);
            //catalogContext.SaveChanges();

            //var brandToDelete = catalogContext.CatalogBrands.Where(b => b.Name == "delete");
            //catalogContext.RemoveRange(brandToDelete);
            //catalogContext.SaveChanges();


            /* USING INCLUDE - one-to-many */
            //List<CatalogBrand> itemsWithInclude = catalogContext.CatalogBrands
            //    .Include(b => b.Items)
            //    .Where(b => b.Items != null)
            //    .ToList();

            /* CASCADE DELETE */
            //CatalogBrand newBrand3 = new CatalogBrand() { ID = 3, Name = "Nev", Description = "Desc", Enabled = true };
            //catalogContext.CatalogBrands.Add(newBrand3);
            //catalogContext.SaveChanges();

            //CatalogItem item = new CatalogItem { Name = "asdf", CatalogBrandId = 3 };
            //catalogContext.CatalogItems.Add(item);
            //catalogContext.SaveChanges();

            //CatalogBrand catalogBrand_3 = catalogContext.CatalogBrands.Find(3);
            //catalogContext.CatalogBrands.Remove(catalogBrand_3);
            //catalogContext.SaveChanges();

            /* MANUAL CONFIGURATION - base */
            List<CatalogBasket> basket = catalogContext.CatalogBaskets
                .Include(cb => cb.Products)
                .ToList();

            /* MANUAL CONFIGURATION - No inverse navigation property */
            List<CatalogItem> catalogItems = catalogContext.CatalogItems
                .Include(ci => ci.CatalogType)
                .ToList();
        }

    }

}
