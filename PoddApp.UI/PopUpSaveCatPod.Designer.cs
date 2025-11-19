namespace PoddApp.UI
{
    partial class PopUpSaveCatPod
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
            lblText = new Label();
            cbChooseCat = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(273, 86);
            lblText.Name = "lblText";
            lblText.Size = new Size(246, 25);
            lblText.TabIndex = 5;
            lblText.Text = "Vilken kategori vill du spara i?";
            //lblText.Click += this.lblText_Click;
            // 
            // cbChooseCat
            // 
            cbChooseCat.FormattingEnabled = true;
            cbChooseCat.Location = new Point(264, 168);
            cbChooseCat.Name = "cbChooseCat";
            cbChooseCat.Size = new Size(255, 33);
            cbChooseCat.TabIndex = 4;
            cbChooseCat.Text = "Välj kategori";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(326, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // PopUpSaveCatPod
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(cbChooseCat);
            Controls.Add(btnSave);
            Name = "PopUpSaveCatPod";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private ComboBox cbChooseCat;
        private Button btnSave;
    }
}