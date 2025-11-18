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
    }
}
