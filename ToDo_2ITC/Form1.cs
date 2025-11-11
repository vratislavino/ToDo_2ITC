using System.Text;

namespace ToDo_2ITC
{
    public partial class Form1 : Form
    {
        List<ToDoData> aufgaben = new List<ToDoData>();
        ToDo editing;
        FileManager fileManager = new FileManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AusDateiLaden();
            AufgabenRendern();
        }

        private void AusDateiLaden()
        {
            aufgaben.AddRange(fileManager.LoadFromFile());
        }

        private void AufgabenRendern()
        {
            flussdiagrammpanel.Controls.Clear();

            foreach (var daten in aufgaben)
            {
                var aufgabensteuerung = new ToDo();
                aufgabensteuerung.SetData(daten);
                aufgabensteuerung.DeleteClicked += OnDeleteClicked;
                aufgabensteuerung.EditClicked += OnEditClicked;
                aufgabensteuerung.TodoChanged += AufgabenRendern;
                flussdiagrammpanel.Controls.Add(aufgabensteuerung);
            }

            ShowCounts();
        }

        private void ShowCounts()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Celkem: {aufgaben.Count}");
            int erledigt = aufgaben.Count(a => a.done);
            sb.AppendLine($"Hotovo: {erledigt}");
            sb.AppendLine($"Nehotovo: {aufgaben.Count - erledigt}");
            label4.Text = sb.ToString();
        }

        private void OnEditClicked(ToDo todoToEdit)
        {
            editing = todoToEdit;
            label1.Text = "Úprava poznámky";
            aufgabentitel.Text = todoToEdit.Data.title;
            aufgabenbeschreibung.Text = todoToEdit.Data.description;


            ErstellungSchalten(!erstellungspanel.Visible);
        }

        private void OnDeleteClicked(ToDo todoToDelete)
        {
            aufgaben.Remove(todoToDelete.Data);
            AufgabenRendern();
        }

        private void erstellen_Klicken(object sender, EventArgs e)
        {
            ErstellungSchalten(!erstellungspanel.Visible);
            editing = null;
            label1.Text = "Vytvoření poznámky";
            aufgabentitel.Focus();
        }

        private void ErstellungSchalten(bool sichtbar)
        {
            erstellungspanel.Visible = sichtbar;
            erstellen.Text = sichtbar ? "Zrušit" : "Vytvořit";
        }

        private void hinzufugen_Klicken(object sender, EventArgs e)
        {
            string titel = aufgabentitel.Text;
            string beschreibung = aufgabenbeschreibung.Text;

            // Validierung später

            aufgabentitel.Clear();
            aufgabenbeschreibung.Clear();

            if (editing == null)
            {
                aufgaben.Add(new ToDoData(
                    0, titel, beschreibung, false
                    ));
            }
            else
            {
                editing.Data.title = titel;
                editing.Data.description = beschreibung;
            }


            AufgabenRendern();
            ErstellungSchalten(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileManager.SaveToFile(aufgaben);
        }
    }
}