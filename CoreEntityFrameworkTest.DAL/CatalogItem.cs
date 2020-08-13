namespace CoreEntityFrameworkTest.DAL
{

    /// <summary>
    /// This is the Dependent entity
    /// </summary>
    public class CatalogItem
    {

        public int? ID { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public int CatalogBrandId { get; set; }

        /// <summary>
        /// Reference navigation entity
        /// </summary>
        /// <remarks>
        /// It is optional. For EF Core, it is enough if the foreign key is defined. 
        /// </remarks>
        public CatalogBrand CatalogBrand { get; set; }

    }

}