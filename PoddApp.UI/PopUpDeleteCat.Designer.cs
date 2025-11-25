namespace PoddApp.UI
{
    partial class PopUpDeleteCat
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
            btnDeleteCat = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.Location = new Point(258, 167);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(95, 27);
            btnDeleteCat.TabIndex = 0;
            btnDeleteCat.Text = "Ta bort";
            btnDeleteCat.UseVisualStyleBackColor = true;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 51);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Välj kategori att ta bort";
            // 
            // button1
            // 
            button1.Location = new Point(29, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tillbaka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PopUpDeleteCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 311);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnDeleteCat);
            Name = "PopUpDeleteCat";
            Text = "PopUpDeleteCat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteCat;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
    }
}