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

        //text box focus control
        #region
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

        private void txtImeP_Focused(object sender, EventArgs e)
        {
            if (txtImeP.Text == "Ime plovila" || txtImeP.Text == "")
                txtImeP.Clear();
        }

        private void txtImeP_UnFocused(object sender, EventArgs e)
        {
            if (txtImeP.Text == "") txtImeP.Text = "Ime plovila";
        }

        private void txtTezina_Focused(object sender, EventArgs e)
        {
            if (txtTezina.Text == "Tezina" || txtTezina.Text == "")
                txtTezina.Clear();
        }

        private void txtTezina_UnFocused(object sender, EventArgs e)
        {
            if (txtTezina.Text == "") txtTezina.Text = "Tezina";
        }

        private void txtSB_Focused(object sender, EventArgs e)
        {
            if (txtSB.Text == "Serijski broj plovila" || txtSB.Text == "")
                txtSB.Clear();
        }

        private void txtSB_UnFocused(object sender, EventArgs e)
        {
            if (txtSB.Text == "") txtSB.Text = "Serijski broj plovila";
        }

        private void txtIme_Focused(object sender, EventArgs e)
        {
            if (txtIme.Text == "Ime" || txtIme.Text == "")
                txtIme.Clear();
        }

        private void txtIme_UnFocused(object sender, EventArgs e)
        {
            if (txtIme.Text == "") txtIme.Text = "Ime";
        }

        private void txtPrezime_Focused(object sender, EventArgs e)
        {
            if (txtPrezime.Text == "Prezime" || txtPrezime.Text == "")
                txtPrezime.Clear();
        }

        private void txtPrezime_UnFocused(object sender, EventArgs e)
        {
            if (txtPrezime.Text == "") txtPrezime.Text = "Prezime";
        }

        private void txtMob_Focused(object sender, EventArgs e)
        {
            if (txtMob.Text == "Broj mobitela" || txtMob.Text == "")
                txtMob.Clear();
        }

        private void txtMob_UnFocused(object sender, EventArgs e)
        {
            if (txtMob.Text == "") txtMob.Text = "Broj mobitela";
        }

        private void txtEmail_Focused(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email" || txtEmail.Text == "")
                txtEmail.Clear();
        }

        private void txtEmail_UnFocused(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") txtEmail.Text = "Email";
        }
        #endregion

    }
}
