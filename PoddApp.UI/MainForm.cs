using PoddApp.BL;
using System;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class MainForm : Form
    {
        private readonly IPoddService _service;

        public MainForm(IPoddService service)
        {
            InitializeComponent();
            _service = service;
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
            LoadPage(new UcDashboard(_service));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new UcAddPod(_service));
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Om du vill lägga till användarbyte här senare
        }
    }
}
