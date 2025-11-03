namespace ToDo_2ITC
{
    public partial class Form1 : Form
    {
        List<ToDoData> todos = new List<ToDoData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            RenderToDos();
        }

        private void LoadFromFile()
        {
            // Later ☺ ♥
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
            todos.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            todos.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
        }

        private void RenderToDos()
        {
            foreach(var data in todos) {
                var todoControl = new ToDo();
                todoControl.SetData(data);
                flowLayoutPanel1.Controls.Add(todoControl);
            }
        }
    }
}
