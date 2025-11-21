using PoddApp.BL;
using PoddApp.DAL;
using System;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class MainForm : Form
    {
        private readonly IPoddService _service;
        private readonly IValidation validation;
        private readonly IPodcastRepo repo;

        public MainForm(IPoddService service, IValidation validation, IPodcastRepo repo)
        {
            InitializeComponent();
            _service = service;
            LoadPage(new UcDashboard(_service, validation));    
            this.validation = validation;
            this.repo = repo;
        }

        private void LoadPage(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadPage(new UcDashboard(_service, validation));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new UcAddPod(_service, validation));
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Om du vill lägga till användarbyte här senare
        }
    }
}
