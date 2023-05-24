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
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Zavrsna_aplikacija
{
    public partial class NoviVez : Form
    {
        List<Plovilo> ListaPlovila = new List<Plovilo>();
        List<Vlasnik> ListaVlasnika = new List<Vlasnik>();

        public NoviVez()
        {
            InitializeComponent();

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

        private void txtDrzReg_Focused(object sender, EventArgs e)
        {
            if (txtDrzReg.Text == "Drzava registracije" || txtDrzReg.Text == "")
                txtDrzReg.Clear();
        }

        private void txtDrzReg_UnFocused(object sender, EventArgs e)
        {
            if (txtDrzReg.Text == "") txtDrzReg.Text = "Drzava registracije";
        }

        private void txtVez_Focused(object sender, EventArgs e)
        {
            if (txtVez.Text == "Vez" || txtVez.Text == "")
                txtVez.Clear();
        }

        private void txtVez_UnFocused(object sender, EventArgs e)
        {
            if (txtVez.Text == "") txtVez.Text = "Vez";
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                
                btnSlika.Hide();
            }
        }

        private void btnPrekid_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //Plovilo
            string registracija = txtDrzReg.Text;
            string ime = txtImeP.Text;
            string serijskiBroj = txtSB.Text;
            string drzavaRegistracije = txtDrzReg.Text;
            int duzina = Convert.ToInt32(txtDuzina.Text);
            int tezina = Convert.ToInt32(txtTezina.Text);
            int godinaReg = Convert.ToInt32(datGodReg.Value.Year.ToString());
            char[] vez = txtVez.Text.ToCharArray();

            //Vlasnik
            string imeVlasnik = txtIme.Text;
            string prezime = txtPrezime.Text;
            string email = txtEmail.Text;
            long brojMob = Convert.ToInt64(txtMob.Text);
            char brevet = Convert.ToChar(cboBrevet.SelectedItem.ToString());

            //Deklaracija klasa
            Vlasnik vlasnik = new Vlasnik(imeVlasnik, prezime, email, brojMob, brevet, rnd.Next());
            Plovilo plovilo = new Plovilo(registracija, ime, serijskiBroj, duzina, tezina, godinaReg, 
                drzavaRegistracije, vez, vlasnik.IDnum);

            //Dodavanje slike u resource file
            string endFilePath = @"resources\" + ime + Path.GetExtension(openFileDialog1.FileName);
            File.Copy(openFileDialog1.FileName, endFilePath);
            plovilo.SlikaPath = endFilePath;

            //upis u csv
            ListaPlovila.Add(plovilo);
            ListaVlasnika.Add(vlasnik);
            using (var writerPlovila = new StreamWriter(@"db\plovila.csv"))
            using (var csvPlovila = new CsvWriter(writerPlovila, CultureInfo.InvariantCulture))
            {
                csvPlovila.WriteRecords(ListaPlovila);
                csvPlovila.NextRecord();
            }
            using (var writerVlasnici = new StreamWriter(@"db\vlasnici.csv"))
            using (var csvVlasnici = new CsvWriter(writerVlasnici, CultureInfo.InvariantCulture))
            {
                csvVlasnici.WriteRecords(ListaVlasnika);
                csvVlasnici.NextRecord();
            }


            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
