namespace PoddApp.UI
{
    partial class UcDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 343);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 413);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(883, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Mina poddar";
            //label1.Click += this.label1_Click;
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UcDashboard";
            Size = new Size(1169, 768);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}
