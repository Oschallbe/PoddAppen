namespace PoddApp.UI
{
    partial class PopUpYesNoFormEp
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
            btnYes = new Button();
            btnNo = new Button();
            lblText = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new Point(103, 197);
            btnYes.Margin = new Padding(2);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(78, 20);
            btnYes.TabIndex = 0;
            btnYes.Text = "Ja";
            btnYes.UseVisualStyleBackColor = true;
            //btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(362, 197);
            btnNo.Margin = new Padding(2);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(78, 20);
            btnNo.TabIndex = 1;
            btnNo.Text = "Nej";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(233, 64);
            lblText.Margin = new Padding(2, 0, 2, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(71, 15);
            lblText.TabIndex = 2;
            lblText.Text = "Är du säker?";
            // 
            // PopUpYesNoFormEp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblText);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Margin = new Padding(2);
            Name = "PopUpYesNoFormEp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Label lblText;
    }
}