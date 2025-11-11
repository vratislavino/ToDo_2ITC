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
        public event Action<ToDo> DeleteClicked;
        public event Action<ToDo> EditClicked;
        public event Action TodoChanged;
        private ToDoData data;

        public ToDoData Data => data;

        public ToDo()
        {
            InitializeComponent();
        }

        // letit is forever in our ♥
        public void SetData(ToDoData data)
        {
            this.data = data;
            todoTitle.Text = data.title;
            description.Text = data.description;
            checkBox1.Checked = data.done;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            data.done = checkBox1.Checked;
            TodoChanged?.Invoke();
        }
    }
}
