namespace PoddApp.UI
{
    partial class PopUpMakeCat
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
            cbCat = new ComboBox();
            tbNameCat = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Skapa kategori";
            // 
            // cbCat
            // 
            cbCat.FormattingEnabled = true;
            cbCat.Location = new Point(203, 91);
            cbCat.Margin = new Padding(2);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(178, 23);
            cbCat.TabIndex = 1;
            cbCat.Text = "Välj avsnitt eller podd";
            cbCat.SelectedIndexChanged += cbCat_SelectedIndexChanged;
            // 
            // tbNameCat
            // 
            tbNameCat.Location = new Point(202, 148);
            tbNameCat.Margin = new Padding(2);
            tbNameCat.Name = "tbNameCat";
            tbNameCat.Size = new Size(179, 23);
            tbNameCat.TabIndex = 2;
            tbNameCat.Text = "Namn på kategorin";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 209);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 3;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // PopUpMakeCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(tbNameCat);
            Controls.Add(cbCat);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PopUpMakeCat";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCat;
        private TextBox tbNameCat;
        private Button btnSave;
        private Button btnBack;
    }
}