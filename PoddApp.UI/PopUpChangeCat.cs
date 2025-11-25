using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PoddApp.UI
{
    public partial class PopUpChangeCat : Form
    {
        public List<Category> NewCategories { get; private set; } = new();
        public PopUpChangeCat(Podcast selectedPodcast, List<Category> allCategories)
        {
            InitializeComponent();

            lblChosenPod.Text = selectedPodcast.Name;
            lblCurrentCat.Text = selectedPodcast.Categories.FirstOrDefault()?.Name ?? "Ingen kategori";

            cbAllCat.DataSource = allCategories;
            cbAllCat.DisplayMember = "Name";

            if (selectedPodcast.Categories.Count == 1)
                cbAllCat.SelectedItem = selectedPodcast.Categories[0].Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbAllCat.SelectedItem is not Category selectedCat)
            {
                MessageBox.Show("Du måste välja en kategori.");
                return;
            }

            NewCategories = new List<Category> { selectedCat };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbAllCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
