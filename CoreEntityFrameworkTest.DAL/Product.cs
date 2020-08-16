namespace CoreEntityFrameworkTest.DAL
{

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