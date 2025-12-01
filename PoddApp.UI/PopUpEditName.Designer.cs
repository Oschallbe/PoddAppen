namespace PoddApp.UI
{
    partial class PopUpEditName
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
            btnBack = new Button();
            btnSave = new Button();
            label1 = new Label();
            tbCurrentName = new TextBox();
            tbNewName = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Tillbaka";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(297, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Redigera namn på podd";
            // 
            // tbCurrentName
            // 
            tbCurrentName.Location = new Point(268, 61);
            tbCurrentName.Name = "tbCurrentName";
            tbCurrentName.Size = new Size(134, 23);
            tbCurrentName.TabIndex = 4;
            tbCurrentName.TextChanged += tbCurrentName_TextChanged;
            // 
            // tbNewName
            // 
            tbNewName.Location = new Point(268, 115);
            tbNewName.Name = "tbNewName";
            tbNewName.Size = new Size(134, 23);
            tbNewName.TabIndex = 5;
            tbNewName.TextChanged += tbNewName_TextChanged;
            // 
            // PopUpEditName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 298);
            Controls.Add(tbNewName);
            Controls.Add(tbCurrentName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Name = "PopUpEditName";
            Text = "Redigera namn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private Label label1;
        private TextBox tbCurrentName;
        private TextBox tbNewName;
    }
}