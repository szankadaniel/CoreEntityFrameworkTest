using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace CoreEntityFrameworkTest.DAL
{

    [Table("NewTestTable", Schema = "dbo")]
    public class NewTestTable
    {

        public int? NewTestTableId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public MyTestEnum TestEnum { get; set; }

        public NewTestTable()
        {

        }

    }

}