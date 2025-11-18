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
            mainPanel = new Panel();
            menuPanel = new Panel();
            cbUser = new ComboBox();
            btnMenu = new Button();
            button1 = new Button();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 53);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1258, 611);
            mainPanel.TabIndex = 2;
            //mainPanel.Paint += panel1_Paint;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(button1);
            menuPanel.Controls.Add(cbUser);
            menuPanel.Controls.Add(btnMenu);
            menuPanel.Dock = DockStyle.Top;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1258, 53);
            menuPanel.TabIndex = 3;
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(1002, 15);
            cbUser.Margin = new Padding(4);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(188, 23);
            cbUser.TabIndex = 2;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(64, 15);
            btnMenu.Margin = new Padding(4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(188, 36);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Meny";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // button1
            // 
            button1.Location = new Point(402, 11);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 3;
            button1.Text = "LaggTillPod";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1258, 664);
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
        private ComboBox cbUser;
        private Button btnMenu;
        private Button button1;
    }
}
