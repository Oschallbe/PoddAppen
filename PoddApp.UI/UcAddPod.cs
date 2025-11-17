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
        public UcAddPod()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var podName = new Episode();
                string podUrl = tbRssUrl.Text;

                podName.Id = Guid.NewGuid().ToString();

                allEpisodes = await aPodService.getEpisodes(podName);

                // Here you would typically add code to save the podcast information
                // For example, you might call a service method to add the podcast to a database
                MessageBox.Show($"Podcast '{podName}' with URL '{podUrl}' added successfully!");
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
