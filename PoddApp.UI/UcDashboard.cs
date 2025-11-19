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
        //private readonly IPodcastRepo _repo;
        private List<Podcast> _podcasts = new();
        private readonly PoddService aPodService;

        public UcDashboard(PoddService poddService)
        {
            InitializeComponent();
            this.aPodService = poddService;
            LoadPods();
        }

        private async Task LoadPods()
        {
            try
            {   
            var allPods = await aPodService.GetAllPodcastsAsync();
                foreach (var pod in allPods)
                {
                    lbMyPod.Items.Add(pod.Name);
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
