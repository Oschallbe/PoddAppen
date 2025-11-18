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
            rtbxMeta = new RichTextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)picbxPicture).BeginInit();
            SuspendLayout();
            // 
            // tbRssUrl
            // 
            tbRssUrl.Location = new Point(187, 52);
            tbRssUrl.Name = "tbRssUrl";
            tbRssUrl.Size = new Size(335, 27);
            tbRssUrl.TabIndex = 0;
            tbRssUrl.Text = "Skriv in RSS länken här";
            // 
            // lblRssUrl
            // 
            lblRssUrl.AutoSize = true;
            lblRssUrl.Location = new Point(117, 55);
            lblRssUrl.Name = "lblRssUrl";
            lblRssUrl.Size = new Size(67, 20);
            lblRssUrl.TabIndex = 1;
            lblRssUrl.Text = "RSS URL:";
            lblRssUrl.Click += label1_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(528, 52);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(83, 27);
            btnFind.TabIndex = 2;
            btnFind.Text = "Sök";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += button1_Click;
            // 
            // lblPodName
            // 
            lblPodName.AutoSize = true;
            lblPodName.Location = new Point(134, 101);
            lblPodName.Name = "lblPodName";
            lblPodName.Size = new Size(50, 20);
            lblPodName.TabIndex = 3;
            lblPodName.Text = "label2";
            lblPodName.Click += lblPodName_Click;
            // 
            // picbxPicture
            // 
            picbxPicture.Location = new Point(28, 124);
            picbxPicture.Name = "picbxPicture";
            picbxPicture.Size = new Size(265, 195);
            picbxPicture.TabIndex = 4;
            picbxPicture.TabStop = false;
            // 
            // lbxEpisodes
            // 
            lbxEpisodes.FormattingEnabled = true;
            lbxEpisodes.Location = new Point(28, 346);
            lbxEpisodes.Name = "lbxEpisodes";
            lbxEpisodes.Size = new Size(309, 124);
            lbxEpisodes.TabIndex = 5;
            // 
            // rtbxDesc
            // 
            rtbxDesc.Location = new Point(344, 124);
            rtbxDesc.Name = "rtbxDesc";
            rtbxDesc.Size = new Size(178, 195);
            rtbxDesc.TabIndex = 6;
            rtbxDesc.Text = "";
            // 
            // rtbxMeta
            // 
            rtbxMeta.Location = new Point(556, 124);
            rtbxMeta.Name = "rtbxMeta";
            rtbxMeta.Size = new Size(169, 195);
            rtbxMeta.TabIndex = 7;
            rtbxMeta.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 441);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "button2";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // UcAddPod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(rtbxMeta);
            Controls.Add(rtbxDesc);
            Controls.Add(lbxEpisodes);
            Controls.Add(picbxPicture);
            Controls.Add(lblPodName);
            Controls.Add(btnFind);
            Controls.Add(lblRssUrl);
            Controls.Add(tbRssUrl);
            Margin = new Padding(2);
            Name = "UcAddPod";
            Size = new Size(762, 525);
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
        private RichTextBox rtbxMeta;
        private Button btnSave;
    }
}
