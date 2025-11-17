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
            btnAddPodcast.Location = new Point(37, 37);
            btnAddPodcast.Margin = new Padding(4, 3, 4, 3);
            btnAddPodcast.Name = "btnAddPodcast";
            btnAddPodcast.Size = new Size(250, 50);
            btnAddPodcast.TabIndex = 0;
            btnAddPodcast.Text = "Lägg till podcast";
            btnAddPodcast.UseVisualStyleBackColor = true;
            btnAddPodcast.Click += btnAddPodcast_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(53, 128);
            btnTestConnection.Margin = new Padding(4, 5, 4, 5);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(193, 38);
            btnTestConnection.TabIndex = 1;
            btnTestConnection.Text = "Testa anslutning\r\n";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 445);
            Controls.Add(btnTestConnection);
            Controls.Add(btnAddPodcast);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "PoddApp";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddPodcast;
        private Button btnTestConnection;
    }
}
