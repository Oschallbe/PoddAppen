using PoddApp.DAL;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class UcDashboard : UserControl
    {
        private readonly IPodcastRepo _repo;
        private List<Podcast> _podcasts = new();

        public UcDashboard(IPodcastRepo repo)
        {
            InitializeComponent();
            _repo = repo;

            _ = LoadPodcastsAsync();
        }

        private async Task LoadPodcastsAsync()
        {
            try
            {   
                _podcasts = await _repo.GetAllAsync() ?? new List<Podcast>();

                lbMyPod.Items.Clear();

                foreach (var p in _podcasts)
                {
                    string title = string.IsNullOrEmpty(p.Name) ? p.RssUrl : p.Name;
                    lbMyPod.Items.Add(title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda poddar: " + ex.Message);
            }
        }

        private void btnDeletePod_Click(object sender, EventArgs e)
        {
            var form = new PopUpYesNoFormPodd();
            form.ShowDialog();   // visar popupen modalt

        }

        private void btnDeletePodEp_Click(object sender, EventArgs e)
        {
            var form = new PopUpYesNoFormEp();
            form.ShowDialog();   // visar popupen modalt
        }

        private void lbMyPod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMyPod_Click(object sender, EventArgs e)
        {

        }

        private void cbPodEpList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMyPodEps_Click(object sender, EventArgs e)
        {

        }

        private void btnEditNameEp_Click(object sender, EventArgs e)
        {

        }

        private void lblMetadataPod_Click(object sender, EventArgs e)
        {

        }

        private void lblMetadataPodEp_Click(object sender, EventArgs e)
        {

        }
    }
}
