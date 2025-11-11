using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ToDo_2ITC
{
    [Serializable]
    public class ToDoData
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool done { get; set; }

        public ToDoData(int id, string title, string desc, bool done)
        {
            this.id = id;
            this.title = title;
            this.description = desc;
            this.done = done;
        }

        public ToDoData()
        { }
    }
}
