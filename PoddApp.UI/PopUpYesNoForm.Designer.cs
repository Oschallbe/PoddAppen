namespace PoddApp.UI
{
    partial class PopUpYesNoForm
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
            btnYes.Location = new Point(147, 329);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(112, 34);
            btnYes.TabIndex = 0;
            btnYes.Text = "Ja";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(517, 329);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(112, 34);
            btnNo.TabIndex = 1;
            btnNo.Text = "Nej";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(333, 107);
            lblText.Name = "lblText";
            lblText.Size = new Size(110, 25);
            lblText.TabIndex = 2;
            lblText.Text = "Är du säker?";
            // 
            // PopUpYesNoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Name = "PopUpYesNoForm";
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