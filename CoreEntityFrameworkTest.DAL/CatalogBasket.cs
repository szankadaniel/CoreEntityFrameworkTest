using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityFrameworkTest.DAL
{

    [Table("CatalogBasket", Schema = "dbo")]
    public class CatalogBasket
    {

        public int? ID { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public CatalogBasket()
        {

        }

    }

}