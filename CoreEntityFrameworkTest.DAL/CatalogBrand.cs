using System.Collections.Generic;

namespace CoreEntityFrameworkTest.DAL
{
    public class CatalogBrand
    {

        public int? ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Enabled { get; set; }

        public List<CatalogItem> Items { get; set; }

    }

}