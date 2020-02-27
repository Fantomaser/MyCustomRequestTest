using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MyCustomRequest
{
    public class JsonConverter
    {
        Logger logger;
        public JsonConverter(Logger _logger) { logger = _logger; }

        public async void MakeJsonToTxt()
        {
            try
            {
                string rawJson;
                User[] users;

                string writePath = Directory.GetCurrentDirectory() + "\\Users.json";
                using (var fSource = new FileStream(writePath, FileMode.Open))
                {
                    users = await JsonSerializer.DeserializeAsync<User[]>(fSource);
                }


                writePath = Directory.GetCurrentDirectory() + "\\UsersConverted.txt";
                using (var fDestination = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    int userCount = 0;
                    DateTime Earliest = users[0].CreatedAt;
                    DateTime Latest = users[0].CreatedAt;



                    foreach (var user in users)
                    {
                        string userInfo = user.FullName + ";\n" + user.Country + ";\n" + user.CreatedAt.ToString() + ";\n" + user.Id.ToString() + ";\n" + user.Email + ";\n";

                        await fDestination.WriteLineAsync(userInfo.ToCharArray(), 0, userInfo.Length);
                        userCount++;
                        if (user.CreatedAt > Latest)
                            Latest = user.CreatedAt;
                        if (user.CreatedAt < Earliest)
                            Earliest = user.CreatedAt;
                    }

                    string fileInfo = string.Format("${0}|{1}@{2}", userCount, Earliest.ToString("dd.MM.yyyy HH:mm:ss"), Latest.ToString("dd.MM.yyyy HH:mm:ss"));

                    await fDestination.WriteLineAsync(fileInfo);

                }
            }
            catch
            {
                logger.LogToFile("File not found", msgState.Error);
            }
            
        }
    }

    public class User
    {
        public User() { }

        [JsonPropertyName("Full Name")]
        public string FullName { get; set; }
        public string Country { get; set; }
        [JsonPropertyName("Created At")]
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
