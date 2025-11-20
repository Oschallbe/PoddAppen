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
    public partial class PopUpChooseList : Form
    {
        public PopUpChooseList()
        {
            InitializeComponent();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbChooseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
