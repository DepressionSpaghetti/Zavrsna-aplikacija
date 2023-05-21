using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zavrsna_aplikacija.Properties;

namespace Zavrsna_aplikacija
{
    public partial class NoviVez : Form
    {

        public NoviVez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                //add filepath to string here
                btnSlika.Hide();
            }
        }
        private void txtRegistracija_UnFocused(object sender, EventArgs e)
        {
            if(txtRegistracija.Text == "") txtRegistracija.Text = "Registracija";
        }

        private void txtRegistracija_Focused(object sender, EventArgs e)
        {
            if(txtRegistracija.Text == "Registracija" || txtRegistracija.Text == "") 
                txtRegistracija.Clear();
        }

        private void txtDuzina_Focused(object sender, EventArgs e)
        {
            if (txtDuzina.Text == "Duzina" || txtDuzina.Text == "")
                txtDuzina.Clear();
        }

        private void txtDuzina_UnFocused(object sender, EventArgs e)
        {
            if (txtDuzina.Text == "") txtDuzina.Text = "Duzina";
        }
    }
}
