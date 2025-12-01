namespace PoddApp.UI
{
    partial class UcAddPod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbRssUrl = new TextBox();
            lblRssUrl = new Label();
            btnFind = new Button();
            lblPodName = new Label();
            picbxPicture = new PictureBox();
            lbxEpisodes = new ListBox();
            rtbxDesc = new RichTextBox();
            rtbxEpDesc = new RichTextBox();
            btnSavePod = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picbxPicture).BeginInit();
            SuspendLayout();
            // 
            // tbRssUrl
            // 
            tbRssUrl.Location = new Point(166, 40);
            tbRssUrl.Margin = new Padding(3, 2, 3, 2);
            tbRssUrl.Name = "tbRssUrl";
            tbRssUrl.Size = new Size(302, 23);
            tbRssUrl.TabIndex = 0;
            tbRssUrl.TextChanged += tbRssUrl_TextChanged;
            // 
            // lblRssUrl
            // 
            lblRssUrl.AutoSize = true;
            lblRssUrl.Font = new Font("Segoe UI", 14F);
            lblRssUrl.Location = new Point(41, 40);
            lblRssUrl.Name = "lblRssUrl";
            lblRssUrl.Size = new Size(85, 25);
            lblRssUrl.TabIndex = 1;
            lblRssUrl.Text = "RSS URL:";
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.System;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(515, 32);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(109, 31);
            btnFind.TabIndex = 2;
            btnFind.Text = "Sök";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += button1_Click;
            // 
            // lblPodName
            // 
            lblPodName.AutoSize = true;
            lblPodName.Location = new Point(194, 77);
            lblPodName.Name = "lblPodName";
            lblPodName.Size = new Size(0, 15);
            lblPodName.TabIndex = 3;
            // 
            // picbxPicture
            // 
            picbxPicture.Location = new Point(24, 111);
            picbxPicture.Margin = new Padding(3, 2, 3, 2);
            picbxPicture.Name = "picbxPicture";
            picbxPicture.Size = new Size(385, 248);
            picbxPicture.TabIndex = 4;
            picbxPicture.TabStop = false;
            picbxPicture.WaitOnLoad = true;
            // 
            // lbxEpisodes
            // 
            lbxEpisodes.FormattingEnabled = true;
            lbxEpisodes.Location = new Point(24, 374);
            lbxEpisodes.Margin = new Padding(3, 2, 3, 2);
            lbxEpisodes.Name = "lbxEpisodes";
            lbxEpisodes.Size = new Size(385, 244);
            lbxEpisodes.TabIndex = 5;
            lbxEpisodes.SelectedIndexChanged += lbxEpisodes_SelectedIndexChanged;
            // 
            // rtbxDesc
            // 
            rtbxDesc.BackColor = SystemColors.ButtonHighlight;
            rtbxDesc.Location = new Point(495, 93);
            rtbxDesc.Margin = new Padding(3, 2, 3, 2);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.ReadOnly = true;
            rtbxDesc.Size = new Size(402, 254);
            rtbxDesc.TabIndex = 6;
            rtbxDesc.Text = "";
            // 
            // rtbxEpDesc
            // 
            rtbxEpDesc.BackColor = SystemColors.ButtonHighlight;
            rtbxEpDesc.Location = new Point(495, 374);
            rtbxEpDesc.Margin = new Padding(3, 2, 3, 2);
            rtbxEpDesc.Name = "rtbxEpDesc";
            rtbxEpDesc.ReadOnly = true;
            rtbxEpDesc.Size = new Size(402, 244);
            rtbxEpDesc.TabIndex = 7;
            rtbxEpDesc.Text = "";
            // 
            // btnSavePod
            // 
            btnSavePod.Font = new Font("Segoe UI", 12F);
            btnSavePod.Location = new Point(941, 577);
            btnSavePod.Margin = new Padding(3, 2, 3, 2);
            btnSavePod.Name = "btnSavePod";
            btnSavePod.Size = new Size(150, 41);
            btnSavePod.TabIndex = 8;
            btnSavePod.Text = "Spara podd";
            btnSavePod.UseVisualStyleBackColor = true;
            btnSavePod.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mina Poddar" });
            comboBox1.Location = new Point(941, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(941, 93);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 10;
            label1.Text = "Välj kategori för podcast:";
            // 
            // UcAddPod
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnSavePod);
            Controls.Add(rtbxEpDesc);
            Controls.Add(rtbxDesc);
            Controls.Add(lbxEpisodes);
            Controls.Add(picbxPicture);
            Controls.Add(lblPodName);
            Controls.Add(btnFind);
            Controls.Add(lblRssUrl);
            Controls.Add(tbRssUrl);
            Margin = new Padding(2);
            Name = "UcAddPod";
            Size = new Size(1190, 696);
            ((System.ComponentModel.ISupportInitialize)picbxPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRssUrl;
        private Label lblRssUrl;
        private Button btnFind;
        private Label lblPodName;
        private PictureBox picbxPicture;
        private ListBox lbxEpisodes;
        private RichTextBox rtbxDesc;
        private RichTextBox rtbxEpDesc;
        private Button btnSavePod;
        private ComboBox comboBox1;
        private Label label1;
    }
}
