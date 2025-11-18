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
        public UcDashboard()
        {
            InitializeComponent();
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
