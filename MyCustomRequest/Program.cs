using System.Linq;
using System.Windows.Forms;
using MyCustomRequest.DB;

namespace MyCustomRequest
{
    static class Program
    {
        static void Main()
        {
            using (DBModel db = new DBModel())
            {
                db.ErrorCodes.RemoveRange(db.ErrorCodes.Select(c=>c));
                db.SaveChanges();
                db.Categories.RemoveRange(db.Categories.Select(c => c));
                db.SaveChanges();
                db.ErrorCodes.Add(new ErrorCode() { Id = 0, infotext = "ddd" });
                db.SaveChanges();
                db.ErrorCodes.RemoveRange(db.ErrorCodes.Select(c => c));
                db.SaveChanges();
                var logger = new Logger("Logfile.txt");
                logger.LogToFile("Program start", msgState.OK);
                var ReqSender = new RequestSender(db);
                var jsonConverter = new JsonConverter(logger);
                var dataLoader = new DataLoader(db);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(logger, ReqSender, jsonConverter, dataLoader));
            }                
        }
    }
}
