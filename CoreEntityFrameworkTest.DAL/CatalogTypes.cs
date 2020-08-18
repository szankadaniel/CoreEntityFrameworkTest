using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityFrameworkTest.DAL
{

    [Table("CatalogType", Schema = "dbo")]
    public class CatalogType
    {
        public int? ID { get; set; }

        public bool IsFree { get; set; }

    }

}