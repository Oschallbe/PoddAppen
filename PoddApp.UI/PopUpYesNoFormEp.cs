using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoddApp.BL;

namespace PoddApp.UI
{
    public partial class PopUpYesNoFormEp : Form
    {
        private readonly IPoddService _service;
        private readonly string _podcastId;
        private readonly string _episodeId;
        public PopUpYesNoFormEp(IPoddService service, string podcastId, string episodeId)
        {
            InitializeComponent();
            _service = service;
            _podcastId = podcastId;
            _episodeId = episodeId;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.DeleteEpisodeAsync(_podcastId, _episodeId);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("kunde inte ta bort avsnitt" + ex.Message);
            }
        }
    }
}
