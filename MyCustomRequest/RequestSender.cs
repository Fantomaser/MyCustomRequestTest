using System;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using MyCustomRequest.DB;

namespace MyCustomRequest
{
    public class RequestSender
    {
        DBModel db;

        public RequestSender(DBModel _db)
        {
            db = _db;
        }

        public void MakeErrorCodesRequest()
        {
            WebRequest request = WebRequest.Create("https://pastebin.com/raw/JK7WiMax");
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            string ReqText = string.Empty;

            using (Stream stream = response.GetResponseStream())
            {

                XmlSerializer formatter = new XmlSerializer(typeof(ErrorCodes));

                ErrorCodes code = (ErrorCodes)formatter.Deserialize(stream);
                foreach (var c in code.ErrorCode)
                {
                    Console.WriteLine($"{c.Id} - {c.infotext} ");

                    byte[] encodedBytes = Encoding.UTF8.GetBytes(c.infotext);
                    byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, encodedBytes);
                    

                    var p1 = new System.Data.SqlClient.SqlParameter("@newcode", c.Id);
                    var p2 = new System.Data.SqlClient.SqlParameter("@newtext", Encoding.Unicode.GetString(unicodeBytes));

                    db.UseToken.WaitOne();
                    db.Database.ExecuteSqlCommand("dbo.SetError @newcode, @newtext", p1, p2);
                    db.SaveChanges();
                    db.UseToken.ReleaseMutex();
                    
                }
                Console.WriteLine("End process");
            }

            

            Console.WriteLine(ReqText);
        }

        public void MakeCategoriesRequest()
        {
            WebRequest request = WebRequest.Create("https://pastebin.com/raw/0RpLbQ19");
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            string ReqText = string.Empty;

            using (Stream stream = response.GetResponseStream())
            {



                XmlSerializer formatter = new XmlSerializer(typeof(Categories));

                Categories code = (Categories)formatter.Deserialize(stream);


                foreach (var c in code.category)
                {
                    Console.WriteLine($"{c.Id} - {c.name} - {c.parent} - {c.image} ");

                    byte[] encodedBytes = Encoding.UTF8.GetBytes(c.name);
                    byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, encodedBytes);

                    byte[] encodedBytes2 = Encoding.UTF8.GetBytes(c.image);
                    byte[] unicodeBytes2 = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, encodedBytes2);


                    var p1 = new System.Data.SqlClient.SqlParameter("@newcid", c.Id);
                    var p2 = new System.Data.SqlClient.SqlParameter("@newname", Encoding.Unicode.GetString(unicodeBytes));
                    var p3 = new System.Data.SqlClient.SqlParameter("@newparent", c.parent);
                    var p4 = new System.Data.SqlClient.SqlParameter("@newimage", Encoding.Unicode.GetString(unicodeBytes2));

                    db.UseToken.WaitOne();
                    db.Database.ExecuteSqlCommand("dbo.SetCategory @newcid, @newname, @newparent, @newimage", p1, p2, p3, p4);
                    db.SaveChanges();
                    db.UseToken.ReleaseMutex();


                }
                Console.WriteLine("End process");


            }

            Console.WriteLine(ReqText);
        }

    }

    [Serializable]
    public class ErrorCodes
    {
        public ErrorCodes() { }
        [XmlElement("ErrorCode")]
        public List<ErrorCode> ErrorCode { get; set; }
    }



    [Serializable]
    public class Categories
    {
        public Categories() { }
        [XmlElement("category")]
        public List<category> category { get; set; }
    }

}
