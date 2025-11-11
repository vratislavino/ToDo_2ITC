
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ToDo_2ITC
{
    internal class FileManager
    {
        public void SaveToFile(List<ToDoData> aufgaben)
        {
            var json = JsonSerializer.Serialize(aufgaben);
            File.WriteAllText("saved.json", json);
        }

        public List<ToDoData> LoadFromFile()
        {
            if (!File.Exists("saved.json"))
            {
                return new List<ToDoData>();
            }

            var json = File.ReadAllText("saved.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            try
            {
                return JsonSerializer.Deserialize<List<ToDoData>>(json, options);
            }
            catch (Exception ex)
            {
                return new List<ToDoData>();
            }

        }
    }
}
