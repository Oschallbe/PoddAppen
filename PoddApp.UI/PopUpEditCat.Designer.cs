namespace PoddApp.UI
{
    partial class PopUpEditCat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSave = new Button();
            tbNewName = new TextBox();
            btnBack = new Button();
            ComboBoxCat = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Redigera namn på kategori";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(237, 163);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 2;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbNewName
            // 
            tbNewName.Location = new Point(194, 120);
            tbNewName.Margin = new Padding(2);
            tbNewName.Name = "tbNewName";
            tbNewName.Size = new Size(171, 23);
            tbNewName.TabIndex = 3;
            tbNewName.Text = "Nytt namn";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Tillbaka";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ComboBoxCat
            // 
            ComboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCat.FormattingEnabled = true;
            ComboBoxCat.Location = new Point(194, 72);
            ComboBoxCat.Name = "ComboBoxCat";
            ComboBoxCat.Size = new Size(171, 23);
            ComboBoxCat.TabIndex = 5;
            // 
            // PopUpEditCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(ComboBoxCat);
            Controls.Add(btnBack);
            Controls.Add(tbNewName);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PopUpEditCat";
            Text = "Redigera kategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox tbNewName;
        private Button btnBack;
        private ComboBox ComboBoxCat;
    }
}