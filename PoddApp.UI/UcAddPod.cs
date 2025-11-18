using PoddApp.BL;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class UcAddPod : UserControl
    {
        private List<Episode> allEpisodes;
        private PoddService aPodService;
        public UcAddPod(PoddService aPodService)
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

                podName.Id = Guid.NewGuid().ToString();

                await aPodService.SetPodcastImageAsync(podName);

                allEpisodes = await aPodService.getEpisodes(podName);

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
    }
}
