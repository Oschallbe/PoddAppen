using PoddApp.BL;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class UcDashboard : UserControl
    {
        private List<Podcast> _podcasts = new();
        private readonly IPoddService _service;

        public UcDashboard(IPoddService service)
        {
            InitializeComponent();
            _service = service;

            _ = LoadPods();  // fire & forget
        }

        private async Task LoadPods()
        {
            try
            {
                _podcasts = await _service.GetAllPodcastsAsync() ?? new List<Podcast>();

                lbMyPod.Items.Clear();

                foreach (var pod in _podcasts)
                {
                    lbMyPod.Items.Add(string.IsNullOrEmpty(pod.Name) ? pod.RssUrl : pod.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda poddar: " + ex.Message);
            }
        }

        private async void btnDeletePod_Click(object sender, EventArgs e)
        {
            int index = lbMyPod.SelectedIndex;

            if (index < 0 || index >= _podcasts.Count)
            {
                MessageBox.Show("Välj en podd att ta bort.");
                return;
            }

            var popup = new PopUpYesNoFormPodd();
            var result = popup.ShowDialog();

            if (result == DialogResult.Yes)
            {
                try
                {
                    var selectedPod = _podcasts[index];

                    await _service.DeletePodcastAsync(selectedPod.Id);

                    // Ta bort från UI-lista
                    lbMyPod.Items.RemoveAt(index);
                    _podcasts.RemoveAt(index);

                    lblMetadataPod.Text = "";
                    lblMetadataPodEp.Text = "";
                    cbPodEpList.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte ta bort podden: " + ex.Message);
                }
            }
        }

        private void btnDeletePodEp_Click(object sender, EventArgs e)
        {
            var form = new PopUpYesNoFormEp();
            form.ShowDialog();
        }

        private void lbMyPod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Här kan vi senare lägga logik för att visa metadata + episoder
        }

        private void lblMyPod_Click(object sender, EventArgs e) { }
        private void cbPodEpList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblMyPodEps_Click(object sender, EventArgs e) { }
        private void btnEditNameEp_Click(object sender, EventArgs e) { }
        private void lblMetadataPod_Click(object sender, EventArgs e) { }
        private void lblMetadataPodEp_Click(object sender, EventArgs e) { }
    }
}
