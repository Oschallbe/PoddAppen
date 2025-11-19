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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(336, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbChooseCat
            // 
            cbChooseCat.FormattingEnabled = true;
            cbChooseCat.Location = new Point(265, 175);
            cbChooseCat.Name = "cbChooseCat";
            cbChooseCat.Size = new Size(255, 33);
            cbChooseCat.TabIndex = 1;
            cbChooseCat.Text = "Välj kategori";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(274, 78);
            lblText.Name = "lblText";
            lblText.Size = new Size(246, 25);
            lblText.TabIndex = 2;
            lblText.Text = "Vilken kategori vill du spara i?";
            lblText.Click += label1_Click;
            // 
            // PopUpSaveCatEp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(cbChooseCat);
            Controls.Add(btnSave);
            Name = "PopUpSaveCatEp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbChooseCat;
        private Label lblText;
    }
}