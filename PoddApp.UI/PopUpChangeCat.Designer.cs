namespace PoddApp.UI
{
    partial class PopUpChangeCat
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
            lblChosenPod = new Label();
            label2 = new Label();
            lblCurrentCat = new Label();
            label3 = new Label();
            cbAllCat = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Vald podd:";
            // 
            // lblChosenPod
            // 
            lblChosenPod.AutoSize = true;
            lblChosenPod.Location = new Point(281, 39);
            lblChosenPod.Name = "lblChosenPod";
            lblChosenPod.Size = new Size(0, 15);
            lblChosenPod.TabIndex = 1;
            lblChosenPod.Click += lblChosenPod_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 82);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuvarande kategori:";
            // 
            // lblCurrentCat
            // 
            lblCurrentCat.AutoSize = true;
            lblCurrentCat.Location = new Point(281, 82);
            lblCurrentCat.Name = "lblCurrentCat";
            lblCurrentCat.Size = new Size(0, 15);
            lblCurrentCat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 129);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Välj ny kategori:";
            // 
            // cbAllCat
            // 
            cbAllCat.FormattingEnabled = true;
            cbAllCat.Location = new Point(281, 126);
            cbAllCat.Name = "cbAllCat";
            cbAllCat.Size = new Size(155, 23);
            cbAllCat.TabIndex = 5;
            cbAllCat.SelectedIndexChanged += cbAllCat_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(251, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Tillbaka";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PopUpChangeCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 280);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(cbAllCat);
            Controls.Add(label3);
            Controls.Add(lblCurrentCat);
            Controls.Add(label2);
            Controls.Add(lblChosenPod);
            Controls.Add(label1);
            Name = "PopUpChangeCat";
            Text = "Ändra kategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblChosenPod;
        private Label label2;
        private Label lblCurrentCat;
        private Label label3;
        private ComboBox cbAllCat;
        private Button btnSave;
        private Button btnBack;
    }
}