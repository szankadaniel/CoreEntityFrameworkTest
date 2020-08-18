using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityFrameworkTest.DAL
{

    [Table("Product", Schema = "dbo")]
    public class Product
    {

        public int? ID { get; set; }

        public string Name { get; set; }

        public CatalogBasket CatalogBaskets { get; set; }

        public Product()
        {

        }

    }

}