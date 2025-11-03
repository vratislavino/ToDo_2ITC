namespace ToDo_2ITC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flussdiagrammpanel = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            erstellungspanel = new Panel();
            hinzufugen = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            aufgabenbeschreibung = new RichTextBox();
            aufgabentitel = new TextBox();
            erstellen = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            erstellungspanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flussdiagrammpanel.AutoScroll = true;
            flussdiagrammpanel.BackColor = SystemColors.ButtonHighlight;
            flussdiagrammpanel.Dock = DockStyle.Fill;
            flussdiagrammpanel.Location = new Point(0, 0);
            flussdiagrammpanel.Name = "flowLayoutPanel1";
            flussdiagrammpanel.Size = new Size(669, 1021);
            flussdiagrammpanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flussdiagrammpanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(erstellungspanel);
            splitContainer1.Panel2.Controls.Add(erstellen);
            splitContainer1.Size = new Size(1312, 1021);
            splitContainer1.SplitterDistance = 669;
            splitContainer1.TabIndex = 1;
            // 
            // erstellungspanel
            // 
            erstellungspanel.BorderStyle = BorderStyle.FixedSingle;
            erstellungspanel.Controls.Add(hinzufugen);
            erstellungspanel.Controls.Add(label3);
            erstellungspanel.Controls.Add(label2);
            erstellungspanel.Controls.Add(label1);
            erstellungspanel.Controls.Add(aufgabenbeschreibung);
            erstellungspanel.Controls.Add(aufgabentitel);
            erstellungspanel.Location = new Point(14, 96);
            erstellungspanel.Name = "erstellungspanel";
            erstellungspanel.Size = new Size(613, 438);
            erstellungspanel.TabIndex = 1;
            erstellungspanel.Visible = false;
            // 
            // hinzufugen
            // 
            hinzufugen.Location = new Point(455, 363);
            hinzufugen.Name = "hinzufugen";
            hinzufugen.Size = new Size(133, 60);
            hinzufugen.TabIndex = 5;
            hinzufugen.Text = "Přidat";
            hinzufugen.UseVisualStyleBackColor = true;
            hinzufugen.Click += hinzufugen_Klicken;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 149);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 4;
            label3.Text = "Popis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 3;
            label2.Text = "Název";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 2;
            label1.Text = "Vytvoření todo";
            // 
            // aufgabenbeschreibung
            // 
            aufgabenbeschreibung.Location = new Point(89, 149);
            aufgabenbeschreibung.Name = "aufgabenbeschreibung";
            aufgabenbeschreibung.Size = new Size(499, 208);
            aufgabenbeschreibung.TabIndex = 1;
            aufgabenbeschreibung.Text = "";
            // 
            // aufgabentitel
            // 
            aufgabentitel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            aufgabentitel.Location = new Point(89, 93);
            aufgabentitel.Name = "aufgabentitel";
            aufgabentitel.Size = new Size(499, 50);
            aufgabentitel.TabIndex = 0;
            // 
            // erstellen
            // 
            erstellen.Location = new Point(420, 12);
            erstellen.Name = "erstellen";
            erstellen.Size = new Size(207, 62);
            erstellen.TabIndex = 0;
            erstellen.Text = "Vytvořit";
            erstellen.UseVisualStyleBackColor = true;
            erstellen.Click += erstellen_Klicken;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 1021);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            erstellungspanel.ResumeLayout(false);
            erstellungspanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flussdiagrammpanel;
        private SplitContainer splitContainer1;
        private Button erstellen;
        private Panel erstellungspanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox aufgabenbeschreibung;
        private TextBox aufgabentitel;
        private Button hinzufugen;
    }
}
