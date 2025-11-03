namespace ToDo_2ITC
{
    partial class ToDo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todoTitle = new Label();
            description = new Label();
            checkBox1 = new CheckBox();
            delete = new Button();
            edit = new Button();
            SuspendLayout();
            // 
            // todoTitle
            // 
            todoTitle.AutoSize = true;
            todoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            todoTitle.Location = new Point(82, 18);
            todoTitle.Name = "todoTitle";
            todoTitle.Size = new Size(91, 38);
            todoTitle.TabIndex = 0;
            todoTitle.Text = "label1";
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            description.ForeColor = SystemColors.GrayText;
            description.Location = new Point(82, 56);
            description.Name = "description";
            description.Size = new Size(71, 30);
            description.TabIndex = 1;
            description.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(31, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(531, 26);
            delete.Name = "delete";
            delete.Size = new Size(62, 55);
            delete.TabIndex = 3;
            delete.Text = "❌";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // edit
            // 
            edit.Location = new Point(463, 26);
            edit.Name = "edit";
            edit.Size = new Size(62, 55);
            edit.TabIndex = 4;
            edit.Text = "✏️";
            edit.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(checkBox1);
            Controls.Add(description);
            Controls.Add(todoTitle);
            Name = "ToDo";
            Size = new Size(617, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label todoTitle;
        private Label description;
        private CheckBox checkBox1;
        private Button delete;
        private Button edit;
    }
}
