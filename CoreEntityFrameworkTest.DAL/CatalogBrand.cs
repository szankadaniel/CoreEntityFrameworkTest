using System.Collections.Generic;

namespace CoreEntityFrameworkTest.DAL
{

    /// <summary>
    /// Principal Entity
    /// </summary>
    public class CatalogBrand
    {

        /// <summary>
        /// Principal entity
        /// </summary>
        public int? ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Enabled { get; set; }

        //public List<CatalogBrandsAndCatalogItems> CatalogBrandsAndCatalogItems { get; set; }

        /// <summary>
        /// Collection navigation property
        /// </summary>
        public List<CatalogItem> Items { get; set; }

    }

}