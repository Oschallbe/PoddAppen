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

namespace PoddApp.UI
{
    public partial class PopUpMakeCat : Form
    {
        private readonly IValidation validation;
        public string? CatName { get; private set; }
        public PopUpMakeCat(IValidation validation)
        {
            InitializeComponent();
            this.validation = validation;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbNameCat.Text.Trim();

            string? error = validation.ValidateEmpty(name);

            if (error != null)
            {
                MessageBox.Show(error, "fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.CatName = name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
