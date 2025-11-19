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
            lblCurrentName = new Label();
            btnSave = new Button();
            tbNewName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 60);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 0;
            label1.Text = "Redigera namn på kategori";
            // 
            // lblCurrentName
            // 
            lblCurrentName.AutoSize = true;
            lblCurrentName.Location = new Point(277, 131);
            lblCurrentName.Name = "lblCurrentName";
            lblCurrentName.Size = new Size(243, 25);
            lblCurrentName.TabIndex = 1;
            lblCurrentName.Text = "Nuvarande namn på kategori";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(338, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tbNewName
            // 
            tbNewName.Location = new Point(277, 200);
            tbNewName.Name = "tbNewName";
            tbNewName.Size = new Size(243, 31);
            tbNewName.TabIndex = 3;
            tbNewName.Text = "Nytt namn";
            // 
            // PopUpEditCat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNewName);
            Controls.Add(btnSave);
            Controls.Add(lblCurrentName);
            Controls.Add(label1);
            Name = "PopUpEditCat";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurrentName;
        private Button btnSave;
        private TextBox tbNewName;
    }
}