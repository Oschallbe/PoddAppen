using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddApp.UI
{
    public partial class PopUpEditName : Form
    {

        public string? NewName { get; private set; }
        public PopUpEditName(string currentName)
        {
            InitializeComponent();

            tbCurrentName.Text = currentName;
            tbCurrentName.ReadOnly = true;
            tbCurrentName.TabStop = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbCurrentName_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbNewName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Nytt namn får inte vara tomt", "fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (name == tbCurrentName.Text)
            {
                MessageBox.Show("Nya nament får inte va samma som det gamla", "ingen ändring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NewName = name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbNewName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
