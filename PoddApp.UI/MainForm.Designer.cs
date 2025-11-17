namespace PoddApp.UI
{
    partial class MainForm
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
            mainPanel = new Panel();
            menuPanel = new Panel();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddPodcast
            // 
            btnAddPodcast.Location = new Point(902, 475);
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
            btnTestConnection.Location = new Point(42, 475);
            btnTestConnection.Margin = new Padding(4, 5, 4, 5);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(193, 38);
            btnTestConnection.TabIndex = 1;
            btnTestConnection.Text = "Testa anslutning\r\n";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click_1;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(btnAddPodcast);
            mainPanel.Controls.Add(btnTestConnection);
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 83);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1224, 620);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += panel1_Paint;
            // 
            // menuPanel
            // 
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1224, 77);
            menuPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 703);
            Controls.Add(menuPanel);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "PoddApp";
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddPodcast;
        private Button btnTestConnection;
        private Panel mainPanel;
        private Panel menuPanel;
    }
}
