namespace PoddApp.UI
{
    partial class UcDashboard
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
            panelMyPods = new Panel();
            btnEditNamePod = new Button();
            btnDeletePod = new Button();
            lbMyPod = new ListBox();
            cbPodCat = new ComboBox();
            cbPodList = new ComboBox();
            lblMyPod = new Label();
            panelMyPodEps = new Panel();
            btnEditNameEp = new Button();
            btnDeletePodEp = new Button();
            lbMyEp = new ListBox();
            cbPodEpCat = new ComboBox();
            cbPodEpList = new ComboBox();
            lblMyPodEps = new Label();
            panelChosenPod = new Panel();
            lbEplist = new ListBox();
            lblMetadataPod = new Label();
            rtbDesc = new RichTextBox();
            picPod = new PictureBox();
            lblPodName = new Label();
            panelChosenEp = new Panel();
            lblMetadataPodEp = new Label();
            rtbDescEp = new RichTextBox();
            picPodEp = new PictureBox();
            lblPodNameEp = new Label();
            panelMyPods.SuspendLayout();
            panelMyPodEps.SuspendLayout();
            panelChosenPod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPod).BeginInit();
            panelChosenEp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPodEp).BeginInit();
            SuspendLayout();
            // 
            // panelMyPods
            // 
            panelMyPods.Controls.Add(btnEditNamePod);
            panelMyPods.Controls.Add(btnDeletePod);
            panelMyPods.Controls.Add(lbMyPod);
            panelMyPods.Controls.Add(cbPodCat);
            panelMyPods.Controls.Add(cbPodList);
            panelMyPods.Controls.Add(lblMyPod);
            panelMyPods.Location = new Point(3, 3);
            panelMyPods.Name = "panelMyPods";
            panelMyPods.Size = new Size(365, 343);
            panelMyPods.TabIndex = 0;
            // 
            // btnEditNamePod
            // 
            btnEditNamePod.Location = new Point(205, 281);
            btnEditNamePod.Name = "btnEditNamePod";
            btnEditNamePod.Size = new Size(140, 34);
            btnEditNamePod.TabIndex = 5;
            btnEditNamePod.Text = "Redigera namn";
            btnEditNamePod.UseVisualStyleBackColor = true;
            // 
            // btnDeletePod
            // 
            btnDeletePod.Location = new Point(26, 281);
            btnDeletePod.Name = "btnDeletePod";
            btnDeletePod.Size = new Size(128, 34);
            btnDeletePod.TabIndex = 4;
            btnDeletePod.Text = "Ta bort podd";
            btnDeletePod.UseVisualStyleBackColor = true;
            btnDeletePod.Click += btnDeletePod_Click;
            // 
            // lbMyPod
            // 
            lbMyPod.FormattingEnabled = true;
            lbMyPod.Location = new Point(26, 90);
            lbMyPod.Name = "lbMyPod";
            lbMyPod.Size = new Size(319, 154);
            lbMyPod.TabIndex = 3;
            // 
            // cbPodCat
            // 
            cbPodCat.FormattingEnabled = true;
            cbPodCat.Location = new Point(214, 51);
            cbPodCat.Name = "cbPodCat";
            cbPodCat.Size = new Size(148, 33);
            cbPodCat.TabIndex = 2;
            // 
            // cbPodList
            // 
            cbPodList.FormattingEnabled = true;
            cbPodList.Location = new Point(214, 12);
            cbPodList.Name = "cbPodList";
            cbPodList.Size = new Size(148, 33);
            cbPodList.TabIndex = 1;
            // 
            // lblMyPod
            // 
            lblMyPod.AutoSize = true;
            lblMyPod.Location = new Point(35, 38);
            lblMyPod.Name = "lblMyPod";
            lblMyPod.Size = new Size(115, 25);
            lblMyPod.TabIndex = 0;
            lblMyPod.Text = "Mina poddar";
            // 
            // panelMyPodEps
            // 
            panelMyPodEps.Controls.Add(btnEditNameEp);
            panelMyPodEps.Controls.Add(btnDeletePodEp);
            panelMyPodEps.Controls.Add(lbMyEp);
            panelMyPodEps.Controls.Add(cbPodEpCat);
            panelMyPodEps.Controls.Add(cbPodEpList);
            panelMyPodEps.Controls.Add(lblMyPodEps);
            panelMyPodEps.Location = new Point(3, 352);
            panelMyPodEps.Name = "panelMyPodEps";
            panelMyPodEps.Size = new Size(365, 413);
            panelMyPodEps.TabIndex = 1;
            // 
            // btnEditNameEp
            // 
            btnEditNameEp.Location = new Point(205, 340);
            btnEditNameEp.Name = "btnEditNameEp";
            btnEditNameEp.Size = new Size(140, 34);
            btnEditNameEp.TabIndex = 5;
            btnEditNameEp.Text = "Redigera namn";
            btnEditNameEp.UseVisualStyleBackColor = true;
            // 
            // btnDeletePodEp
            // 
            btnDeletePodEp.Location = new Point(25, 340);
            btnDeletePodEp.Name = "btnDeletePodEp";
            btnDeletePodEp.Size = new Size(143, 34);
            btnDeletePodEp.TabIndex = 4;
            btnDeletePodEp.Text = "Ta bort avsnitt";
            btnDeletePodEp.UseVisualStyleBackColor = true;
            btnDeletePodEp.Click += btnDeletePodEp_Click;
            // 
            // lbMyEp
            // 
            lbMyEp.FormattingEnabled = true;
            lbMyEp.Location = new Point(26, 97);
            lbMyEp.Name = "lbMyEp";
            lbMyEp.Size = new Size(319, 204);
            lbMyEp.TabIndex = 3;
            // 
            // cbPodEpCat
            // 
            cbPodEpCat.FormattingEnabled = true;
            cbPodEpCat.Location = new Point(215, 58);
            cbPodEpCat.Name = "cbPodEpCat";
            cbPodEpCat.Size = new Size(147, 33);
            cbPodEpCat.TabIndex = 2;
            // 
            // cbPodEpList
            // 
            cbPodEpList.FormattingEnabled = true;
            cbPodEpList.Location = new Point(214, 18);
            cbPodEpList.Name = "cbPodEpList";
            cbPodEpList.Size = new Size(148, 33);
            cbPodEpList.TabIndex = 1;
            // 
            // lblMyPodEps
            // 
            lblMyPodEps.AutoSize = true;
            lblMyPodEps.Location = new Point(16, 26);
            lblMyPodEps.Name = "lblMyPodEps";
            lblMyPodEps.Size = new Size(152, 25);
            lblMyPodEps.TabIndex = 0;
            lblMyPodEps.Text = "Mina poddavsnitt";
            // 
            // panelChosenPod
            // 
            panelChosenPod.Controls.Add(lbEplist);
            panelChosenPod.Controls.Add(lblMetadataPod);
            panelChosenPod.Controls.Add(rtbDesc);
            panelChosenPod.Controls.Add(picPod);
            panelChosenPod.Controls.Add(lblPodName);
            panelChosenPod.Location = new Point(374, 3);
            panelChosenPod.Name = "panelChosenPod";
            panelChosenPod.Size = new Size(432, 762);
            panelChosenPod.TabIndex = 2;
            // 
            // lbEplist
            // 
            lbEplist.FormattingEnabled = true;
            lbEplist.Location = new Point(68, 446);
            lbEplist.Name = "lbEplist";
            lbEplist.Size = new Size(331, 204);
            lbEplist.TabIndex = 5;
            // 
            // lblMetadataPod
            // 
            lblMetadataPod.AutoSize = true;
            lblMetadataPod.Location = new Point(184, 385);
            lblMetadataPod.Name = "lblMetadataPod";
            lblMetadataPod.Size = new Size(129, 25);
            lblMetadataPod.TabIndex = 3;
            lblMetadataPod.Text = "MetadataPodd";
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(68, 283);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(331, 86);
            rtbDesc.TabIndex = 4;
            rtbDesc.Text = "";
            // 
            // picPod
            // 
            picPod.Location = new Point(68, 64);
            picPod.Name = "picPod";
            picPod.Size = new Size(331, 213);
            picPod.TabIndex = 1;
            picPod.TabStop = false;
            // 
            // lblPodName
            // 
            lblPodName.AutoSize = true;
            lblPodName.Location = new Point(161, 20);
            lblPodName.Name = "lblPodName";
            lblPodName.Size = new Size(120, 25);
            lblPodName.TabIndex = 0;
            lblPodName.Text = "NamnPåPodd";
            // 
            // panelChosenEp
            // 
            panelChosenEp.Controls.Add(lblMetadataPodEp);
            panelChosenEp.Controls.Add(rtbDescEp);
            panelChosenEp.Controls.Add(picPodEp);
            panelChosenEp.Controls.Add(lblPodNameEp);
            panelChosenEp.Location = new Point(812, 3);
            panelChosenEp.Name = "panelChosenEp";
            panelChosenEp.Size = new Size(354, 762);
            panelChosenEp.TabIndex = 3;
            // 
            // lblMetadataPodEp
            // 
            lblMetadataPodEp.AutoSize = true;
            lblMetadataPodEp.Location = new Point(102, 385);
            lblMetadataPodEp.Name = "lblMetadataPodEp";
            lblMetadataPodEp.Size = new Size(184, 25);
            lblMetadataPodEp.TabIndex = 3;
            lblMetadataPodEp.Text = "MetadataPoddAvsnitt";
            // 
            // rtbDescEp
            // 
            rtbDescEp.Location = new Point(54, 283);
            rtbDescEp.Name = "rtbDescEp";
            rtbDescEp.Size = new Size(267, 86);
            rtbDescEp.TabIndex = 2;
            rtbDescEp.Text = "";
            // 
            // picPodEp
            // 
            picPodEp.Location = new Point(54, 64);
            picPodEp.Name = "picPodEp";
            picPodEp.Size = new Size(266, 213);
            picPodEp.TabIndex = 1;
            picPodEp.TabStop = false;
            // 
            // lblPodNameEp
            // 
            lblPodNameEp.AutoSize = true;
            lblPodNameEp.Location = new Point(111, 20);
            lblPodNameEp.Name = "lblPodNameEp";
            lblPodNameEp.Size = new Size(175, 25);
            lblPodNameEp.TabIndex = 0;
            lblPodNameEp.Text = "NamnPåPoddAvsnitt";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelChosenEp);
            Controls.Add(panelChosenPod);
            Controls.Add(panelMyPodEps);
            Controls.Add(panelMyPods);
            Name = "UcDashboard";
            panelMyPods.ResumeLayout(false);
            panelMyPods.PerformLayout();
            panelMyPodEps.ResumeLayout(false);
            panelMyPodEps.PerformLayout();
            panelChosenPod.ResumeLayout(false);
            panelChosenPod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPod).EndInit();
            panelChosenEp.ResumeLayout(false);
            panelChosenEp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPodEp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMyPods;
        private Label lblMyPod;
        private Panel panelMyPodEps;
        private Panel panelChosenPod;
        private Label lblMyPodEps;
        private Label lblPodName;
        private ComboBox cbPodCat;
        private ComboBox cbPodList;
        private ComboBox cbPodEpCat;
        private ComboBox cbPodEpList;
        private PictureBox picPod;
        private Panel panelChosenEp;
        private Label lblMetadataPod;
        private ListBox lbEplist;
        private RichTextBox rtbDesc;
        private PictureBox picPodEp;
        private Label lblPodNameEp;
        private Label lblMetadataPodEp;
        private RichTextBox rtbDescEp;
        private ListBox lbMyPod;
        private Button btnDeletePod;
        private ListBox lbMyEp;
        private Button btnEditNamePod;
        private Button btnDeletePodEp;
        private Button btnEditNameEp;
    }
}
