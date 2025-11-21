using MongoDB.Driver;
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
        private List<Episode> allEpisodes;
        private readonly IValidation validate;

        public UcDashboard(IPoddService service, IValidation validation)
        {
            InitializeComponent();
            _service = service;
            validate = validation;


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

        public static string StripHtml(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            return System.Text.RegularExpressions.Regex.Replace(input, "<.*?>", string.Empty);
        }

        public Podcast GetPodcasts(string name)
        {
            return _podcasts.FirstOrDefault(podcast => podcast.Name == name);

        }

        private async void lbMyPod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbMyPod.SelectedIndex;

            if (index < 0 || index >= _podcasts.Count)
                return;

            var selectedPodcast = _podcasts[index];

            if (selectedPodcast == null)
                return;


            if (!string.IsNullOrEmpty(selectedPodcast.Name))
            {
                lblPodName.Text = selectedPodcast.Name;
            }
            else
            {
                lblPodName.Text = "Namnlös Podd";
            }

            if (!string.IsNullOrEmpty(selectedPodcast.Description))
            {
                rtbDesc.Text = StripHtml(selectedPodcast.Description);
            }
            else
            {
                rtbDesc.Text = "Beskrivning saknas";
            }

            if (!string.IsNullOrEmpty(selectedPodcast.ImageUrl))
            {
                try
                {
                    picPod.SizeMode = PictureBoxSizeMode.Zoom; // viktigt så den skalar in bilden
                    picPod.Load(selectedPodcast.ImageUrl);   // WinForms klarar URL automatiskt!
                }
                catch
                {
                    picPod.Image = null; // eller en fallback-bild
                }
            }
            allEpisodes = await _service.GetEpisodesAsync(selectedPodcast);
            selectedPodcast.Episodes = allEpisodes; // valfritt men bra

            lbEplist.Items.Clear();
            foreach (var ep in allEpisodes)
            {
                lbEplist.Items.Add(ep.Title);
            }
        }

        private void lblMyPod_Click(object sender, EventArgs e) { }
        private void cbPodEpList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblMyPodEps_Click(object sender, EventArgs e) { }
        private async void btnEditNameEp_Click(object sender, EventArgs e)
        {
            var popup = new PopUpMakeCat(validate);
            var result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                await _service.AddCategoryAsync(popup.CatName);
                MessageBox.Show("Kategori sparad!");
            }
        }
        private void lblMetadataPod_Click(object sender, EventArgs e) { }
        private void lblMetadataPodEp_Click(object sender, EventArgs e) { }

        private void lblPodName_Click(object sender, EventArgs e)
        {

        }

        private void picPod_Click(object sender, EventArgs e)
        {

        }

        private void lbEplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbEplist.SelectedIndex;

            if (index < 0 || index >= allEpisodes.Count)
                return;

            var selectedEpisode = allEpisodes[index];

            if (selectedEpisode == null)
                return;

            // Titel
            if (!string.IsNullOrEmpty(selectedEpisode.Title))
            {
                lblPodNameEp.Text = selectedEpisode.Title;
            }
            else
            {
                lblPodNameEp.Text = "Namnlös episode";
            }

            // Beskrivning
            if (!string.IsNullOrEmpty(selectedEpisode.Description))
            {
                rtbDescEp.Text = StripHtml(selectedEpisode.Description);
            }
            else
            {
                rtbDescEp.Text = "Beskrivning saknas";
            }

            // Datum
            if (selectedEpisode.PublishedDate != DateTime.MinValue)
            {
                lblDate.Text = selectedEpisode.PublishedDate.ToString("yyyy-MM-dd");
            }
            else
            {
                lblDate.Text = "Datum saknas";
            }

            // 🔥 Bild
            var episodeImage = selectedEpisode.ImageUrl;
            var podcastImage = _podcasts[lbMyPod.SelectedIndex].ImageUrl;

            // 🔥 Visa inte episodbild om:
            // - den är null/empty
            // - den är samma som podcastens bild
            if (!string.IsNullOrEmpty(episodeImage) &&
                !string.Equals(episodeImage, podcastImage, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    picPodEp.SizeMode = PictureBoxSizeMode.Zoom;
                    picPodEp.Load(episodeImage);
                }
                catch
                {
                    picPodEp.Image = null;
                }
            }
            else
            {
                picPodEp.Image = null;
            }
        }

        private void cbPodCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
