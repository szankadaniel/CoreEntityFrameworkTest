using System.Collections.Generic;

namespace CoreEntityFrameworkTest.DAL
{

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