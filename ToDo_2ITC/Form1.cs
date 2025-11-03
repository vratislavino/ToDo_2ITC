namespace ToDo_2ITC
{
    public partial class Form1 : Form
    {
        List<ToDoData> aufgaben = new List<ToDoData>();

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
            // Later ☺ ♥
            aufgaben.Add(
                new ToDoData(0, "Naučit se hrát fotbal", "Not really", false)
                );
            aufgaben.Add(
                new ToDoData(1, "Zapomenout na fotbal", "Yes please", false)
                );
        }

        private void AufgabenRendern()
        {
            flussdiagrammpanel.Controls.Clear();

            foreach (var daten in aufgaben)
            {
                var aufgabensteuerung = new ToDo();
                aufgabensteuerung.SetData(daten);
                aufgabensteuerung.DeleteClicked += OnDeleteClicked;
                flussdiagrammpanel.Controls.Add(aufgabensteuerung);
            }
        }

        private void OnDeleteClicked(ToDo todoToDelete)
        {
            aufgaben.Remove(todoToDelete.Data);
            AufgabenRendern();
        }

        private void erstellen_Klicken(object sender, EventArgs e)
        {
            ErstellungSchalten(!erstellungspanel.Visible);
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

            aufgaben.Add(new ToDoData(
                0, titel, beschreibung, false
                ));

            AufgabenRendern();
            ErstellungSchalten(false); 
        }
    }
}


/*
 Create
 Read
 Update
 Delete
 */