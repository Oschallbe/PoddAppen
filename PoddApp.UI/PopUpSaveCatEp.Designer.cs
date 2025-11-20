namespace PoddApp.UI
{
    partial class PopUpSaveCatEp
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
            btnSave = new Button();
            cbChooseCat = new ComboBox();
            lblText = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(235, 183);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbChooseCat
            // 
            cbChooseCat.FormattingEnabled = true;
            cbChooseCat.Location = new Point(186, 105);
            cbChooseCat.Margin = new Padding(2, 2, 2, 2);
            cbChooseCat.Name = "cbChooseCat";
            cbChooseCat.Size = new Size(180, 23);
            cbChooseCat.TabIndex = 1;
            cbChooseCat.Text = "Välj kategori";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(192, 47);
            lblText.Margin = new Padding(2, 0, 2, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(162, 15);
            lblText.TabIndex = 2;
            lblText.Text = "Vilken kategori vill du spara i?";
            lblText.Click += label1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Tillbaka";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PopUpSaveCatEp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnBack);
            Controls.Add(lblText);
            Controls.Add(cbChooseCat);
            Controls.Add(btnSave);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PopUpSaveCatEp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbChooseCat;
        private Label lblText;
        private Button btnBack;
    }
}