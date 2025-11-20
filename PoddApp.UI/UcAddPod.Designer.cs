namespace PoddApp.UI
{
    partial class UcAddPod
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
            ((System.ComponentModel.ISupportInitialize)picbxPicture).BeginInit();
            SuspendLayout();
            // 
            // tbRssUrl
            // 
            tbRssUrl.Location = new Point(164, 39);
            tbRssUrl.Margin = new Padding(3, 2, 3, 2);
            tbRssUrl.Name = "tbRssUrl";
            tbRssUrl.Size = new Size(294, 23);
            tbRssUrl.TabIndex = 0;
            tbRssUrl.TextChanged += tbRssUrl_TextChanged;
            // 
            // lblRssUrl
            // 
            lblRssUrl.AutoSize = true;
            lblRssUrl.Location = new Point(102, 41);
            lblRssUrl.Name = "lblRssUrl";
            lblRssUrl.Size = new Size(53, 15);
            lblRssUrl.TabIndex = 1;
            lblRssUrl.Text = "RSS URL:";
            lblRssUrl.Click += label1_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(462, 39);
            btnFind.Margin = new Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(73, 20);
            btnFind.TabIndex = 2;
            btnFind.Text = "Sök";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += button1_Click;
            // 
            // lblPodName
            // 
            lblPodName.AutoSize = true;
            lblPodName.Location = new Point(102, 66);
            lblPodName.Name = "lblPodName";
            lblPodName.Size = new Size(22, 15);
            lblPodName.TabIndex = 3;
            lblPodName.Text = "XD";
            lblPodName.Click += lblPodName_Click;
            // 
            // picbxPicture
            // 
            picbxPicture.Location = new Point(24, 93);
            picbxPicture.Margin = new Padding(3, 2, 3, 2);
            picbxPicture.Name = "picbxPicture";
            picbxPicture.Size = new Size(232, 146);
            picbxPicture.TabIndex = 4;
            picbxPicture.TabStop = false;
            picbxPicture.WaitOnLoad = true;
            // 
            // lbxEpisodes
            // 
            lbxEpisodes.FormattingEnabled = true;
            lbxEpisodes.Location = new Point(24, 260);
            lbxEpisodes.Margin = new Padding(3, 2, 3, 2);
            lbxEpisodes.Name = "lbxEpisodes";
            lbxEpisodes.Size = new Size(271, 94);
            lbxEpisodes.TabIndex = 5;
            lbxEpisodes.SelectedIndexChanged += lbxEpisodes_SelectedIndexChanged;
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(301, 93);
            rtbxDesc.Margin = new Padding(3, 2, 3, 2);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(234, 147);
            rtbxDesc.TabIndex = 6;
            rtbxDesc.Text = "";
            // 
            // rtbxEpDesc
            // 
            rtbxEpDesc.Location = new Point(309, 260);
            rtbxEpDesc.Margin = new Padding(3, 2, 3, 2);
            rtbxEpDesc.Name = "rtbxEpDesc";
            rtbxEpDesc.Size = new Size(226, 94);
            rtbxEpDesc.TabIndex = 7;
            rtbxEpDesc.Text = "";
            // 
            // btnSavePod
            // 
            btnSavePod.Location = new Point(548, 331);
            btnSavePod.Margin = new Padding(3, 2, 3, 2);
            btnSavePod.Name = "btnSavePod";
            btnSavePod.Size = new Size(87, 22);
            btnSavePod.TabIndex = 8;
            btnSavePod.Text = "Spara podd";
            btnSavePod.UseVisualStyleBackColor = true;
            btnSavePod.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mina Poddar" });
            comboBox1.Location = new Point(551, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 9;
            // 
            // UcAddPod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(738, 404);
            Load += UcAddPod_Load;
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
    }
}
