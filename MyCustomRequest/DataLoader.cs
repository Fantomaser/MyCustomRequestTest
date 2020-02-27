using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomRequest.DB;

namespace MyCustomRequest
{
    public class DataLoader
    {
        DBModel db;

        public DataLoader(DBModel _db) { db = _db; }

        public string ShowData()
        {
            string result = string.Empty;

            var _category = db.Database.SqlQuery<category>("ShowData");
            foreach(var cat in _category)
            {
                result += $"{cat.Id}  {cat.parent, 10}  {cat.name, 30}  {cat.image, 70} " + " \n";
            }
            return result;
        }
    }
}
