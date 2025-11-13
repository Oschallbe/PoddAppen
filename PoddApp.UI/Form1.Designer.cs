namespace PoddApp.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnAddPodcast = new Button();
            btnTestConnection = new Button();
            SuspendLayout();
            // 
            // btnAddPodcast
            // 
            btnAddPodcast.Location = new Point(26, 22);
            btnAddPodcast.Margin = new Padding(3, 2, 3, 2);
            btnAddPodcast.Name = "btnAddPodcast";
            btnAddPodcast.Size = new Size(175, 30);
            btnAddPodcast.TabIndex = 0;
            btnAddPodcast.Text = "Lägg till podcast";
            btnAddPodcast.UseVisualStyleBackColor = true;
            btnAddPodcast.Click += btnAddPodcast_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(37, 77);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(135, 23);
            btnTestConnection.TabIndex = 1;
            btnTestConnection.Text = "Testa anslutning\r\n";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 150);
            Controls.Add(btnTestConnection);
            Controls.Add(btnAddPodcast);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "PoddApp";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddPodcast;
        private Button btnTestConnection;
    }
}
