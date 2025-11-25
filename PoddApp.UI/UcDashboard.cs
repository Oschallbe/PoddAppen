using MongoDB.Driver;
using PoddApp.BL;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class UcDashboard : UserControl
    {
        private List<Podcast> _podcasts = new();
        private readonly IPoddService _service;
        private List<Episode> allEpisodes;
        private readonly IValidation validate;
        private List<Category> _categories = new();

        public UcDashboard(IPoddService service, IValidation validation)
        {
            InitializeComponent();
            _service = service;
            validate = validation;
            _ = LoadPods();
            _ = LoadCategories();
        }

        private async Task LoadPods()
        {
            try
            {
                _podcasts = await _service.GetAllPodcastsAsync() ?? new List<Podcast>();

                UpdatePodcastList(_podcasts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda poddar: " + ex.Message);
            }
        }

        private async Task LoadCategories()
        {
            _categories = await _service.GetAllCategoriesAsync();

            cbPodCat.Items.Clear();

            // Första valet = Alla kategorier
            cbPodCat.Items.Add(new ComboBoxItem
            {
                Text = "Alla",
                Value = null
            });

            // Lägg in varje kategori
            foreach (var cat in _categories)
            {
                cbPodCat.Items.Add(new ComboBoxItem
                {
                    Text = cat.Name,
                    Value = cat.Id
                });
            }

            cbPodCat.SelectedIndex = 0;
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; } // categoryId
            public override string ToString() => Text;
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte ta bort podden: " + ex.Message);
                }
            }
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

            lblPodNameEp.Text = "";
            picPodEp.Image = null;
            lblDate.Text = "";
            rtbDescEp.Clear();

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
                    picPod.Load(selectedPodcast.ImageUrl);
                }
                catch
                {
                    picPod.Image = null;
                }
            }
            allEpisodes = await _service.GetEpisodesAsync(selectedPodcast);
            selectedPodcast.Episodes = allEpisodes;

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

            if (!string.IsNullOrEmpty(selectedEpisode.Title))
            {
                lblPodNameEp.Text = selectedEpisode.Title;
            }
            else
            {
                lblPodNameEp.Text = "Namnlös episode";
            }

            if (!string.IsNullOrEmpty(selectedEpisode.Description))
            {
                rtbDescEp.Text = StripHtml(selectedEpisode.Description);
            }
            else
            {
                rtbDescEp.Text = "Beskrivning saknas";
            }


            if (selectedEpisode.PublishedDate != DateTime.MinValue)
            {
                lblDate.Text = selectedEpisode.PublishedDate.ToString("yyyy-MM-dd");
            }
            else
            {
                lblDate.Text = "Datum saknas";
            }


            var episodeImage = selectedEpisode.ImageUrl;
            var podcastImage = _podcasts[lbMyPod.SelectedIndex].ImageUrl;

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
                picPodEp.Image = Image.FromFile("Resources/Dummy_Bild.png");
                picPodEp.SizeMode = PictureBoxSizeMode.Zoom;


            }
        }

        private void UpdatePodcastList(List<Podcast> list)
        {
            lbMyPod.Items.Clear();

            foreach (var p in list)
            {
                lbMyPod.Items.Add(string.IsNullOrEmpty(p.Name) ? p.RssUrl : p.Name);
            }
        }

        private void cbPodCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_podcasts == null || _podcasts.Count == 0)
                return;

            ComboBoxItem? selected = cbPodCat.SelectedItem as ComboBoxItem;
            if (selected == null)
                return;


            lblMyPod.Text = selected.Value == null
                ? "Alla kategorier"
                : selected.Text;


            if (selected.Value == null)
            {
                UpdatePodcastList(_podcasts);
                return;
            }

            string selectedCategoryId = selected.Value;


            var filtered = _podcasts
                .Where(p => p.Categories != null &&
                            p.Categories.Any(c => c.Id == selectedCategoryId))
                .ToList();

            UpdatePodcastList(filtered);
        }

        private async void btnEditNamePod_Click(object sender, EventArgs e)
        {
            var selectedPodcast = lbMyPod.SelectedItem as Podcast;
            if (selectedPodcast == null) return;

            var popup = new PopUpEditName(selectedPodcast.Name);
            var result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    await _service.ChangeNamePodcastAsync(selectedPodcast.Id, popup.NewName);

                    selectedPodcast.Name = popup.NewName;
                    UpdatePodcastList(_podcasts);
                    lblPodName.Text = selectedPodcast.Name;
                    MessageBox.Show("Poddens namn uppdaterades!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte uppdatera podden: " + ex.Message);
                }
            }
        }

        private void cbPodSort_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_podcasts == null || _podcasts.Count == 0)
                return;

            string choice = cbPodSort.SelectedItem?.ToString();

            if (choice == "Sortera...")
                return;

            List<Podcast> sortedList = _podcasts;

            if (choice == "A–Ö")
            {
                sortedList = _podcasts
                    .OrderBy(p => p.Name)
                    .ToList();
            }

            UpdatePodcastList(sortedList);
        }

        private async void btnChangeCat_Click(object sender, EventArgs e)
        {
            int index = lbMyPod.SelectedIndex;
            if (index < 0) return;

            var selectedPodcast = _podcasts[index];

            var allCategories = await _service.GetAllCategoriesAsync();

            //var popup = new PopUpChangeCat(selectedPodcast.Categories, allCategories);
            //var result = popup.ShowDialog();

            //if (result == DialogResult.OK)
            {
                try
                {
                    //await _service.ChangeCategoryPodcastAsync(selectedPodcast, popup.NewCategories);
                    //selectedPodcast.Categories = popup.NewCategories;

                    MessageBox.Show("Kategori har ändrats!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte ändra kategori: " + ex.Message);
                }
            }
        }
    }
}

