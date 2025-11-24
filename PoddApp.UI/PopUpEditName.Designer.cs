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
            NameLabel1 = new Label();
            tbCurrentName = new TextBox();
            textBox1 = new TextBox();
            btnBack = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // NameLabel1
            // 
            NameLabel1.AutoSize = true;
            NameLabel1.Location = new Point(236, 45);
            NameLabel1.Name = "NameLabel1";
            NameLabel1.Size = new Size(134, 15);
            NameLabel1.TabIndex = 0;
            NameLabel1.Text = "Redigera namn på podd";
            // 
            // tbCurrentName
            // 
            tbCurrentName.Location = new Point(236, 93);
            tbCurrentName.Name = "tbCurrentName";
            tbCurrentName.Size = new Size(100, 23);
            tbCurrentName.TabIndex = 1;
            tbCurrentName.TextChanged += tbCurrentName_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // btnSave
            // 
            btnSave.Location = new Point(261, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PopUpEditName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 290);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(textBox1);
            Controls.Add(tbCurrentName);
            Controls.Add(NameLabel1);
            Name = "PopUpEditName";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel1;
        private TextBox tbCurrentName;
        private TextBox textBox1;
        private Button btnBack;
        private Button btnSave;
    }
}