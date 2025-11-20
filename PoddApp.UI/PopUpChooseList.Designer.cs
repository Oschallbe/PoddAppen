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
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(239, 168);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 20);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbChooseList
            // 
            cbChooseList.FormattingEnabled = true;
            cbChooseList.Location = new Point(153, 103);
            cbChooseList.Margin = new Padding(2);
            cbChooseList.Name = "cbChooseList";
            cbChooseList.Size = new Size(269, 23);
            cbChooseList.TabIndex = 1;
            cbChooseList.SelectedIndexChanged += cbChooseList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 15);
            label1.TabIndex = 2;
            label1.Text = "Vänligen välj vilken lista du vill spara avsnittet i: ";
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
            // PopUpChooseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(cbChooseList);
            Controls.Add(btnSave);
            Margin = new Padding(2);
            Name = "PopUpChooseList";
            Text = "PopUpChooseList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbChooseList;
        private Label label1;
        private Button btnBack;
    }
}