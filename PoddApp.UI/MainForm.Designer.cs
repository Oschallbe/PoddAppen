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
            btnAddPodcast.Location = new Point(722, 380);
            btnAddPodcast.Margin = new Padding(3, 2, 3, 2);
            btnAddPodcast.Name = "btnAddPodcast";
            btnAddPodcast.Size = new Size(200, 40);
            btnAddPodcast.TabIndex = 0;
            btnAddPodcast.Text = "Lägg till podcast";
            btnAddPodcast.UseVisualStyleBackColor = true;
            btnAddPodcast.Click += btnAddPodcast_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(34, 380);
            btnTestConnection.Margin = new Padding(3, 4, 3, 4);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(154, 30);
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
            mainPanel.Location = new Point(0, 66);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(979, 496);
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
            menuPanel.Size = new Size(979, 62);
            menuPanel.TabIndex = 3;
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(816, 28);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(151, 28);
            cbUser.TabIndex = 2;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(149, 23);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(150, 29);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Meny";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAddPod
            // 
            btnAddPod.Location = new Point(451, 23);
            btnAddPod.Name = "btnAddPod";
            btnAddPod.Size = new Size(150, 29);
            btnAddPod.TabIndex = 0;
            btnAddPod.Text = "Lägg till ny podcast";
            btnAddPod.UseVisualStyleBackColor = true;
            btnAddPod.Click += btnAddPod_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 562);
            Controls.Add(menuPanel);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
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
