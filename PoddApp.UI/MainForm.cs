using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PoddApp.BL;
using PoddApp.DAL;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class MainForm : Form
    {
        private readonly PodcastRepository _repo;
        private readonly IPodcastRepo _Irepo;
        private PoddService aPodService;


        public MainForm(PoddService podService, IPodcastRepo repo)
        {
            InitializeComponent();
            aPodService = podService;
            _Irepo = repo;
            _repo = repo as PodcastRepository; // Ensure _repo is initialized

            LoadPage(new UcDashboard(_Irepo));

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
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
            LoadPage(new UcDashboard(_Irepo));
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new UcAddPod(aPodService, _Irepo));
        }
    }
}
