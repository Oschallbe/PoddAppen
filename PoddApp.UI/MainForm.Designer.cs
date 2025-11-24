namespace PoddApp.UI
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;
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
            mainPanel = new Panel();
            menuPanel = new Panel();
            btnLaggTillPod = new Button();
            btnMenu = new Button();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 53);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1264, 727);
            mainPanel.TabIndex = 2;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(176, 196, 222);
            menuPanel.Controls.Add(btnLaggTillPod);
            menuPanel.Controls.Add(btnMenu);
            menuPanel.Dock = DockStyle.Top;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1264, 53);
            menuPanel.TabIndex = 3;
            // 
            // btnLaggTillPod
            // 
            btnLaggTillPod.Font = new Font("Segoe UI", 14F);
            btnLaggTillPod.Location = new Point(950, 4);
            btnLaggTillPod.Margin = new Padding(4);
            btnLaggTillPod.Name = "btnLaggTillPod";
            btnLaggTillPod.Size = new Size(177, 45);
            btnLaggTillPod.TabIndex = 3;
            btnLaggTillPod.Text = "Lägg till Podcast";
            btnLaggTillPod.UseVisualStyleBackColor = true;
            btnLaggTillPod.Click += button1_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 14F);
            btnMenu.Location = new Point(67, 4);
            btnMenu.Margin = new Padding(4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(184, 43);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Meny";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1264, 780);
            Controls.Add(mainPanel);
            Controls.Add(menuPanel);
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1024, 600);
            Name = "MainForm";
            Text = "PoddApp";
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel menuPanel;
        private Button btnMenu;
        private Button button1;
        private Button btnLaggTillPod;
    }
}
