using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyCustomRequest
{
    public enum msgState{
        OK = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    }


    public class Logger
    {
        bool IsDisposed = false; 
        StreamWriter file;

        public Logger(string fName)
        {
            string writePath = Directory.GetCurrentDirectory() + "\\" + fName;
            file = new StreamWriter(writePath, true, System.Text.Encoding.Default);
        }

        public async void LogToFile(string value, msgState state)
        {
            
            switch (state)
            {
                case msgState.OK:
                    await file.WriteLineAsync($"[OK] -- <{value}> : {DateTime.Now}");
                    break;
                case msgState.Info:
                    await file.WriteLineAsync($"[Info] -- <{value}> : {DateTime.Now}");
                    break;
                case msgState.Warning:
                    await file.WriteLineAsync($"[WARNING] -- <{value}> : {DateTime.Now}");
                    break;
                case msgState.Error:
                    await file.WriteLineAsync($"[ERROR] -- <{value}> : {DateTime.Now}");
                    break;
            }

            await file.FlushAsync();
        }

        protected void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    file.Flush();
                    file.Dispose();
                }
                IsDisposed = true;
            }
        }

        
        ~Logger()
        {
            Dispose(false);
        }

    }
}
