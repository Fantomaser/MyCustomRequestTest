using System.Data.Entity;
using System.Threading;

namespace MyCustomRequest.DB
{
    public class DBModel : DbContext
    {
        public Mutex UseToken = new Mutex();

        public DBModel() : base("DbConnection") { }

        public DbSet<category> Categories { get; set; }
        public DbSet<ErrorCode> ErrorCodes { get; set; }
    }
}
