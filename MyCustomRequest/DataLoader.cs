using System.Linq;
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

            db.UseToken.WaitOne();
            var _category = db.Database.SqlQuery<category>("ShowData").ToList();
            db.UseToken.ReleaseMutex();
            if (_category.Count() < 1)
                return "------------------- NO DATA ----------------------";
            foreach(var cat in _category)
            {
                result += $"{cat.Id}  {cat.parent, 10}  {cat.name, 30}  {cat.image, 70} " + " \n";
            }
            return result;
        }
    }
}
