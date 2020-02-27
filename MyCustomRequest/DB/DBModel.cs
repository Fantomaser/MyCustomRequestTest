using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyCustomRequest.DB
{
    public class DBModel : DbContext
    {
        public DBModel() : base("DbConnection") { }

        public DbSet<category> Categories { get; set; }
        public DbSet<ErrorCode> ErrorCodes { get; set; }
    }
}
