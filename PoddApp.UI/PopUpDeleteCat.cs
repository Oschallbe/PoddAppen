

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoddApp.BL; 
using PoddApp.Models;

namespace PoddApp.UI
{
    public partial class PopUpDeleteCat : Form
    {
        private readonly IPoddService _service;
        private List<Category> _allCategories = new();

        public PopUpDeleteCat(IPoddService service)
        {
            InitializeComponent();
            _service = service;
            _ = LoadCategories(); 
        }

        private async Task LoadCategories()
        {
            try
            {
                _allCategories = await _service.GetAllCategoriesAsync();

                
                comboBox1.DataSource = _allCategories.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox1.SelectedIndex = -1; 
                comboBox1.Text = "Välj kategori att ta bort";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte ladda kategorier: {ex.Message}");
                
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tom, men nödvändig för att matcha designer-filen
        }

        private async void btnDeleteCat_Click(object sender, EventArgs e)
        {
            var selectedCategory = comboBox1.SelectedItem as Category;

            if (selectedCategory == null)
            {
                MessageBox.Show("Vänligen välj en kategori att radera.");
                return;
            }

           
            using (var popup = new PopUpYesNoFormPodd())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _service.DeleteCategoryAsync(selectedCategory.Id);

                        MessageBox.Show($"Kategorin '{selectedCategory.Name}' har raderats!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kunde inte radera kategori: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}