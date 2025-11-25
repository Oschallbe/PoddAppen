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
        public PopUpChangeCat(List<Category> currentCategory, List<Category> allCategories)
        {
            InitializeComponent();

            cbAllCat.DataSource = allCategories.Select(c => c.Name).ToList();

            if (currentCategory.Count == 1)
                cbAllCat.SelectedItem = currentCategory[0].Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbAllCat.SelectedItem == null)
            {
                MessageBox.Show("Du måste välja en kategori.");
                return;
            }

            string NewCategory = cbAllCat.SelectedItem.ToString();
            NewCategories = new List<Category> { new Category { Name = NewCategory } };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbAllCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
