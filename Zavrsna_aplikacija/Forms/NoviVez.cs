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
using System.Security.Cryptography.X509Certificates;

namespace Zavrsna_aplikacija
{
    public partial class NoviVez : Form
    {
        //Plovilo
        string registracija, ime, serijskiBroj, drzavaRegistracije;
        int duzina, tezina, godinaReg;
        char[] vez = new char[10];
        
        public string Registracija { get => registracija; set => registracija = value; }
        public string Ime { get => ime; set => ime = value; }
        public string SerijskiBroj { get => serijskiBroj; set => serijskiBroj = value; }
        public string DrzavaRegistracije { get => drzavaRegistracije; set => drzavaRegistracije = value; }
        public int Duzina { get => duzina; set => duzina = value; }
        public int Tezina { get => tezina; set => tezina = value; }
        public int GodinaReg { get => godinaReg; set => godinaReg = value; }
        public char[] Vez { get => vez; set => vez = value; }

        //Vlasnik
        string imeVlasnik, prezime, email;
        long brojMob;
        char brevet;
        Random rnd = new Random();

        public string ImeVlasnik { get => imeVlasnik; set => imeVlasnik = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public long BrojMob { get => brojMob; set => brojMob = value; }
        public char Brevet { get => brevet; set => brevet = value; }
        public Random Rnd { get => rnd; set=> rnd = value; }

        //Other
        string endFilePath;

        public string EndFilePath { get => endFilePath; }


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

            //Plovilo
            registracija = txtDrzReg.Text;
            ime = txtImeP.Text;
            serijskiBroj = txtSB.Text;
            drzavaRegistracije = txtDrzReg.Text;
            duzina = Convert.ToInt32(txtDuzina.Text);
            tezina = Convert.ToInt32(txtTezina.Text);
            godinaReg = Convert.ToInt32(datGodReg.Value.Year.ToString());
            vez = txtVez.Text.ToCharArray();



            //Vlasnik
            imeVlasnik = txtIme.Text;
            prezime = txtPrezime.Text;
            email = txtEmail.Text;
            brojMob = Convert.ToInt64(txtMob.Text);
            brevet = Convert.ToChar(cboBrevet.SelectedItem.ToString());

            //Deklaracija klasa


            //Dodavanje slike u resource file
            endFilePath = @"resources\" + ime + Path.GetExtension(openFileDialog1.FileName);
            File.Copy(openFileDialog1.FileName, endFilePath);


            DialogResult = DialogResult.OK;
        }
    }
}
