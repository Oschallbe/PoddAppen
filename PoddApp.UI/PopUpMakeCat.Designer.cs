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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 67);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Skapa kategori";
            // 
            // cbCat
            // 
            cbCat.FormattingEnabled = true;
            cbCat.Location = new Point(290, 151);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(252, 33);
            cbCat.TabIndex = 1;
            cbCat.Text = "Välj avsnitt eller podd";
            // 
            // tbNameCat
            // 
            tbNameCat.Location = new Point(288, 246);
            tbNameCat.Name = "tbNameCat";
            tbNameCat.Size = new Size(254, 31);
            tbNameCat.TabIndex = 2;
            tbNameCat.Text = "Namn på kategorin";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(345, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // PopUpMakeCat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(tbNameCat);
            Controls.Add(cbCat);
            Controls.Add(label1);
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
    }
}