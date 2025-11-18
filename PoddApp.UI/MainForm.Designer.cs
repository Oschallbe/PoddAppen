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
            cbUser = new ComboBox();
            btnMenu = new Button();
            btnAddPod = new Button();
            mainPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddPodcast
            // 
            btnAddPodcast.Location = new Point(902, 475);
            btnAddPodcast.Margin = new Padding(4, 2, 4, 2);
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
            btnTestConnection.Size = new Size(192, 38);
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
            mainPanel.Location = new Point(0, 44);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1258, 620);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += panel1_Paint;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(cbUser);
            menuPanel.Controls.Add(btnMenu);
            menuPanel.Controls.Add(btnAddPod);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1224, 78);
            menuPanel.TabIndex = 3;
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(1020, 35);
            cbUser.Margin = new Padding(4, 4, 4, 4);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(188, 33);
            cbUser.TabIndex = 2;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(186, 29);
            btnMenu.Margin = new Padding(4, 4, 4, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(188, 36);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Meny";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAddPod
            // 
            btnAddPod.Location = new Point(564, 29);
            btnAddPod.Margin = new Padding(4, 4, 4, 4);
            btnAddPod.Name = "btnAddPod";
            btnAddPod.Size = new Size(188, 36);
            btnAddPod.TabIndex = 0;
            btnAddPod.Text = "Lägg till ny podcast";
            btnAddPod.UseVisualStyleBackColor = true;
            btnAddPod.Click += btnAddPod_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1258, 664);
            Controls.Add(menuPanel);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1024, 600);
            Name = "MainForm";
            Text = "PoddApp";
            mainPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddPodcast;
        private Button btnTestConnection;
        private Panel mainPanel;
        private Panel menuPanel;
        private ComboBox cbUser;
        private Button btnMenu;
        private Button btnAddPod;
    }
}
