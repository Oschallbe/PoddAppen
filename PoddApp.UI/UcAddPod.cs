using PoddApp.BL;
using PoddApp.DAL;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PoddApp.UI
{
    public partial class UcAddPod : UserControl
    {
        private List<Episode> allEpisodes;
        private readonly IPoddService aPodService;

        public UcAddPod(IPoddService aPodService)
        {
            InitializeComponent();
            this.aPodService = aPodService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var podName = new Podcast();

                podName.RssUrl = tbRssUrl.Text;

                podName.Id = podName.Id++;

                await aPodService.SetPodcastTitleAsync(podName);

                await aPodService.SetPodcastImageAsync(podName);

                await aPodService.SetPodcastDescriptionAsync(podName);

                allEpisodes = await aPodService.GetEpisodesAsync(podName);

                lblPodName.Text = podName.Name;

                rtbxDesc.Text = podName.Description;

                lbxEpisodes.Items.Clear();

                foreach (Episode anEpisode in allEpisodes)
                {
                    lbxEpisodes.Items.Add(anEpisode.Title);

                }

                if (!string.IsNullOrEmpty(podName.ImageUrl))
                {
                    picbxPicture.SizeMode = PictureBoxSizeMode.Zoom; // viktigt så den skalar in bilden
                    picbxPicture.LoadAsync(podName.ImageUrl);

                }
                else
                {
                    MessageBox.Show("Bild hittas inte.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPodName_Click(object sender, EventArgs e)
        {

        }

        private void UcAddPod_Load(object sender, EventArgs e)
        {

        }
        public static string StripHtml(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            return System.Text.RegularExpressions.Regex.Replace(input, "<.*?>", string.Empty);
        }


        private void lbxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxEpisodes.SelectedIndex;

            if (index < 0 || index >= allEpisodes.Count)
                return;

            Episode selectedEpisode = allEpisodes[index];

            rtbxEpDesc.Text = StripHtml(selectedEpisode.Description);
        }


        private void tbRssUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pod = new Podcast
                {
                    Name = lblPodName.Text,
                    Description = rtbxDesc.Text,
                    RssUrl = tbRssUrl.Text,
                    ImageUrl = picbxPicture.ImageLocation,
                    Episodes = allEpisodes
                };

                await aPodService.SavePodcastAsync(pod);

                MessageBox.Show("Podcast saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the podcast: {ex.Message}");
            }
        }
    }
}
