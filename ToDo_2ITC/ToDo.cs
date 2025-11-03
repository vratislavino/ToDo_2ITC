using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_2ITC
{
    public partial class ToDo : UserControl
    {

        public ToDo()
        {
            InitializeComponent();
        }

        // letit is forever in our ♥
        public void SetData(ToDoData data)
        {
            todoTitle.Text = data.title;
            description.Text = data.description;
            checkBox1.Checked = data.done;
        }
    }
}
