using CoreEntityFrameworkTest.DAL;
using System.Linq;

namespace CoreEntityFrameworkTest.ConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CatalogContext catalogContext = new CatalogContext();

            /* CREATE */
            CatalogBrand newBrand = new CatalogBrand() { Name = "Nev", Description = "Desc", Enabled = true };
            catalogContext.CatalogBrands.Add(newBrand);
            catalogContext.SaveChanges();

            /* UPDATE */
            CatalogBrand brand = catalogContext.CatalogBrands.Find(3);
            brand.Enabled = true;
            catalogContext.SaveChanges();

            /* GET */
            /* Add the call to ToListAsync in order to execute the query immediately. Otherwise, the statement will assign an IQueryable<SelectListItem> to brandItems, which will not be executed until it is enumerated. */
            var items = catalogContext.CatalogBrands
                .Where(b => b.Enabled == true)
                .OrderByDescending(b => b.ID)
                .ToList();

            /* CREATE THEN DELETE */
            newBrand = new CatalogBrand() { Name = "delete", Description = "Desc", Enabled = true };
            catalogContext.CatalogBrands.Add(newBrand);
            catalogContext.SaveChanges();

            var brandToDelete = catalogContext.CatalogBrands.Where(b => b.Name == "delete");
            catalogContext.RemoveRange(brandToDelete);
            catalogContext.SaveChanges();
        }

    }

}
