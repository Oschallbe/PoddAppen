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
            btnAddCat = new Button();
            btnEditNamePod = new Button();
            btnDeletePod = new Button();
            lbMyPod = new ListBox();
            cbPodCat = new ComboBox();
            cbPodSort = new ComboBox();
            lblMyPod = new Label();
            panelMyPodEps = new Panel();
            panelChosenPod = new Panel();
            label1 = new Label();
            lbEplist = new ListBox();
            lblMetadataPod = new Label();
            rtbDesc = new RichTextBox();
            picPod = new PictureBox();
            lblPodName = new Label();
            panelChosenEp = new Panel();
            label3 = new Label();
            label2 = new Label();
            lblDate = new Label();
            lblMetadataPodEp = new Label();
            rtbDescEp = new RichTextBox();
            picPodEp = new PictureBox();
            lblPodNameEp = new Label();
            panelMyPods.SuspendLayout();
            panelChosenPod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPod).BeginInit();
            panelChosenEp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPodEp).BeginInit();
            SuspendLayout();
            // 
            // panelMyPods
            // 
            panelMyPods.Controls.Add(btnAddCat);
            panelMyPods.Controls.Add(btnEditNamePod);
            panelMyPods.Controls.Add(btnDeletePod);
            panelMyPods.Controls.Add(lbMyPod);
            panelMyPods.Controls.Add(cbPodCat);
            panelMyPods.Controls.Add(cbPodSort);
            panelMyPods.Controls.Add(lblMyPod);
            panelMyPods.Location = new Point(2, 2);
            panelMyPods.Margin = new Padding(2);
            panelMyPods.Name = "panelMyPods";
            panelMyPods.Size = new Size(388, 684);
            panelMyPods.TabIndex = 0;
            // 
            // btnAddCat
            // 
            btnAddCat.Font = new Font("Segoe UI", 12F);
            btnAddCat.Location = new Point(17, 528);
            btnAddCat.Margin = new Padding(2);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(80, 57);
            btnAddCat.TabIndex = 5;
            btnAddCat.Text = "Lägg till kategori";
            btnAddCat.UseVisualStyleBackColor = true;
            btnAddCat.Click += btnEditNameEp_Click;
            // 
            // btnEditNamePod
            // 
            btnEditNamePod.Font = new Font("Segoe UI", 12F);
            btnEditNamePod.Location = new Point(138, 528);
            btnEditNamePod.Margin = new Padding(2);
            btnEditNamePod.Name = "btnEditNamePod";
            btnEditNamePod.Size = new Size(80, 57);
            btnEditNamePod.TabIndex = 5;
            btnEditNamePod.Text = "Redigera namn";
            btnEditNamePod.UseVisualStyleBackColor = true;
            btnEditNamePod.Click += btnEditNamePod_Click;
            // 
            // btnDeletePod
            // 
            btnDeletePod.Font = new Font("Segoe UI", 12F);
            btnDeletePod.Location = new Point(251, 528);
            btnDeletePod.Margin = new Padding(2);
            btnDeletePod.Name = "btnDeletePod";
            btnDeletePod.Size = new Size(80, 57);
            btnDeletePod.TabIndex = 4;
            btnDeletePod.Text = "Ta bort podd";
            btnDeletePod.UseVisualStyleBackColor = true;
            btnDeletePod.Click += btnDeletePod_Click;
            // 
            // lbMyPod
            // 
            lbMyPod.FormattingEnabled = true;
            lbMyPod.Location = new Point(2, 89);
            lbMyPod.Margin = new Padding(2);
            lbMyPod.Name = "lbMyPod";
            lbMyPod.Size = new Size(386, 424);
            lbMyPod.TabIndex = 3;
            lbMyPod.SelectedIndexChanged += lbMyPod_SelectedIndexChanged;
            // 
            // cbPodCat
            // 
            cbPodCat.FormattingEnabled = true;
            cbPodCat.Location = new Point(280, 47);
            cbPodCat.Margin = new Padding(2);
            cbPodCat.Name = "cbPodCat";
            cbPodCat.Size = new Size(105, 23);
            cbPodCat.TabIndex = 2;
            cbPodCat.Text = "Välj kategori";
            cbPodCat.SelectedIndexChanged += cbPodCat_SelectedIndexChanged;
            // 
            // cbPodSort
            // 
            cbPodSort.FormattingEnabled = true;
            cbPodSort.Location = new Point(280, 9);
            cbPodSort.Margin = new Padding(2);
            cbPodSort.Name = "cbPodSort";
            cbPodSort.Size = new Size(105, 23);
            cbPodSort.TabIndex = 1;
            cbPodSort.Text = "Sortera";
            // 
            // lblMyPod
            // 
            lblMyPod.AutoSize = true;
            lblMyPod.Font = new Font("Segoe UI", 14F);
            lblMyPod.Location = new Point(97, 29);
            lblMyPod.Margin = new Padding(2, 0, 2, 0);
            lblMyPod.Name = "lblMyPod";
            lblMyPod.Size = new Size(121, 25);
            lblMyPod.TabIndex = 0;
            lblMyPod.Text = "Mina poddar";
            lblMyPod.Click += lblMyPod_Click;
            // 
            // panelMyPodEps
            // 
            panelMyPodEps.Location = new Point(2, 690);
            panelMyPodEps.Margin = new Padding(2);
            panelMyPodEps.Name = "panelMyPodEps";
            panelMyPodEps.Size = new Size(388, 10);
            panelMyPodEps.TabIndex = 1;
            // 
            // panelChosenPod
            // 
            panelChosenPod.Controls.Add(label1);
            panelChosenPod.Controls.Add(lbEplist);
            panelChosenPod.Controls.Add(lblMetadataPod);
            panelChosenPod.Controls.Add(rtbDesc);
            panelChosenPod.Controls.Add(picPod);
            panelChosenPod.Controls.Add(lblPodName);
            panelChosenPod.Location = new Point(394, 2);
            panelChosenPod.Margin = new Padding(2);
            panelChosenPod.Name = "panelChosenPod";
            panelChosenPod.Size = new Size(400, 696);
            panelChosenPod.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(141, 245);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 6;
            label1.Text = "Poddbeskrivning";
            // 
            // lbEplist
            // 
            lbEplist.FormattingEnabled = true;
            lbEplist.Location = new Point(29, 472);
            lbEplist.Margin = new Padding(2);
            lbEplist.Name = "lbEplist";
            lbEplist.Size = new Size(355, 184);
            lbEplist.TabIndex = 5;
            lbEplist.SelectedIndexChanged += lbEplist_SelectedIndexChanged;
            // 
            // lblMetadataPod
            // 
            lblMetadataPod.AutoSize = true;
            lblMetadataPod.Font = new Font("Segoe UI", 12F);
            lblMetadataPod.Location = new Point(141, 440);
            lblMetadataPod.Margin = new Padding(2, 0, 2, 0);
            lblMetadataPod.Name = "lblMetadataPod";
            lblMetadataPod.Size = new Size(61, 21);
            lblMetadataPod.TabIndex = 3;
            lblMetadataPod.Text = "Avsnitt:";
            lblMetadataPod.Click += lblMetadataPod_Click;
            // 
            // rtbDesc
            // 
            rtbDesc.Location = new Point(29, 268);
            rtbDesc.Margin = new Padding(2);
            rtbDesc.Name = "rtbDesc";
            rtbDesc.Size = new Size(355, 143);
            rtbDesc.TabIndex = 4;
            rtbDesc.Text = "";
            // 
            // picPod
            // 
            picPod.Location = new Point(87, 47);
            picPod.Margin = new Padding(2);
            picPod.Name = "picPod";
            picPod.Size = new Size(243, 170);
            picPod.TabIndex = 1;
            picPod.TabStop = false;
            picPod.Click += picPod_Click;
            // 
            // lblPodName
            // 
            lblPodName.AutoSize = true;
            lblPodName.Font = new Font("Segoe UI", 14F);
            lblPodName.Location = new Point(141, 12);
            lblPodName.Margin = new Padding(2, 0, 2, 0);
            lblPodName.Name = "lblPodName";
            lblPodName.Size = new Size(126, 25);
            lblPodName.TabIndex = 0;
            lblPodName.Text = "NamnPåPodd";
            lblPodName.Click += lblPodName_Click;
            // 
            // panelChosenEp
            // 
            panelChosenEp.Controls.Add(label3);
            panelChosenEp.Controls.Add(label2);
            panelChosenEp.Controls.Add(lblDate);
            panelChosenEp.Controls.Add(lblMetadataPodEp);
            panelChosenEp.Controls.Add(rtbDescEp);
            panelChosenEp.Controls.Add(picPodEp);
            panelChosenEp.Controls.Add(lblPodNameEp);
            panelChosenEp.Location = new Point(798, 2);
            panelChosenEp.Margin = new Padding(0);
            panelChosenEp.Name = "panelChosenEp";
            panelChosenEp.Size = new Size(400, 696);
            panelChosenEp.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(103, 16);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 6;
            label3.Text = "Avsnittsnamn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 305);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Publicerat datum:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(210, 305);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 15);
            lblDate.TabIndex = 4;
            // 
            // lblMetadataPodEp
            // 
            lblMetadataPodEp.AutoSize = true;
            lblMetadataPodEp.Font = new Font("Segoe UI", 12F);
            lblMetadataPodEp.Location = new Point(103, 356);
            lblMetadataPodEp.Margin = new Padding(2, 0, 2, 0);
            lblMetadataPodEp.Name = "lblMetadataPodEp";
            lblMetadataPodEp.Size = new Size(146, 21);
            lblMetadataPodEp.TabIndex = 3;
            lblMetadataPodEp.Text = "Avsnittsbeskrivning";
            lblMetadataPodEp.Click += lblMetadataPodEp_Click;
            // 
            // rtbDescEp
            // 
            rtbDescEp.Location = new Point(36, 391);
            rtbDescEp.Margin = new Padding(2);
            rtbDescEp.Name = "rtbDescEp";
            rtbDescEp.Size = new Size(300, 270);
            rtbDescEp.TabIndex = 2;
            rtbDescEp.Text = "";
            // 
            // picPodEp
            // 
            picPodEp.Location = new Point(103, 101);
            picPodEp.Margin = new Padding(2);
            picPodEp.Name = "picPodEp";
            picPodEp.Size = new Size(233, 170);
            picPodEp.TabIndex = 1;
            picPodEp.TabStop = false;
            // 
            // lblPodNameEp
            // 
            lblPodNameEp.AutoSize = true;
            lblPodNameEp.Location = new Point(103, 55);
            lblPodNameEp.Margin = new Padding(2, 0, 2, 0);
            lblPodNameEp.Name = "lblPodNameEp";
            lblPodNameEp.Size = new Size(118, 15);
            lblPodNameEp.TabIndex = 0;
            lblPodNameEp.Text = "NamnPåPoddAvsnitt";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelChosenEp);
            Controls.Add(panelChosenPod);
            Controls.Add(panelMyPodEps);
            Controls.Add(panelMyPods);
            Margin = new Padding(2);
            Name = "UcDashboard";
            Size = new Size(1200, 700);
            panelMyPods.ResumeLayout(false);
            panelMyPods.PerformLayout();
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
        private Label lblPodName;
        private ComboBox cbPodCat;
        private ComboBox cbPodSort;
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
        private Button btnEditNamePod;
        private Button btnAddCat;
        private Label label1;
        private Label lblDate;
        private Label label2;
        private Label label3;
    }
}
