using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityFrameworkTest.DAL
{

    /// <summary>
    /// Principal Entity
    /// </summary>
    [Table("CatalogBrand", Schema = "dbo")]
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