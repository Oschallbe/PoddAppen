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
using PoddApp.Models;

namespace PoddApp.UI
{
    public partial class PopUpEditCat : Form
    {
        private readonly IPoddService service;
        private readonly IValidation validation;
        private readonly List<Category> categories;
        public PopUpEditCat(IPoddService service, IValidation validation, List<Category> categories)
        {
            InitializeComponent();
            this.service = service;
            this.validation = validation;
            this.categories = categories;

            ComboBoxCat.DataSource = categories;
            ComboBoxCat.DisplayMember = "Name";
            ComboBoxCat.ValueMember = "Id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ComboBoxCat.SelectedItem is not Category selectedCat)
            {
                MessageBox.Show("Välj kategori först", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string NewName = tbNewName.Text.Trim();

            string error = this.validation.ValidateEmpty(NewName);
            if (error != null)
            {
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await this.service.ChangeCategoryNameAsync(selectedCat.Id, NewName);

                selectedCat.Name = NewName;

                ComboBoxCat.DisplayMember = "";
                ComboBoxCat.DisplayMember = "Name";

                MessageBox.Show("Kategori uppdaterat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gick inte att uppdatera" + ex.Message);
            }
        }
    }
}