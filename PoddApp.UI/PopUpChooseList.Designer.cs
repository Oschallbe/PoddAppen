namespace PoddApp.UI
{
    partial class PopUpChooseList
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
            cbChooseList = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(341, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbChooseList
            // 
            cbChooseList.FormattingEnabled = true;
            cbChooseList.Location = new Point(219, 172);
            cbChooseList.Name = "cbChooseList";
            cbChooseList.Size = new Size(382, 33);
            cbChooseList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 62);
            label1.Name = "label1";
            label1.Size = new Size(386, 25);
            label1.TabIndex = 2;
            label1.Text = "Vänligen välj vilken lista du vill spara avsnittet i: ";
            // 
            // PopUpChooseList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cbChooseList);
            Controls.Add(btnSave);
            Name = "PopUpChooseList";
            Text = "PopUpChooseList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbChooseList;
        private Label label1;
    }
}