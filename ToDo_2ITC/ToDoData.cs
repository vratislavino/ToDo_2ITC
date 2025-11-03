using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_2ITC
{
    public class ToDoData
    {
        public int id;
        public string title;
        public string description;
        public bool done;

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
