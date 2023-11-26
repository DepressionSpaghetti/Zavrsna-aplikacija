using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka.Forms
{
    public partial class DodajKorisnika : Form
    {
        bool exceptionFound = false;
        string email, ime, prezime, adresa;
        long brojTelefona;

        public string Email { get => email; }
        public string Ime { get => ime; }
        public string Prezime { get => prezime; }
        public string Adresa { get => adresa; }
        public long BrojTelefona { get => brojTelefona; }

        string EmailS { set => email = value; }
        string ImeS { set => ime = value; }
        string PrezimeS { set => prezime = value; }
        string AdresaS { set => adresa = value; }
        long BrojTelefonaS { set => brojTelefona = value; }


        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPrihvati_Click(object sender, EventArgs e)
        {
            exceptionFound = false;

            try
            {
                EmailS = txtMail.Text;
                ImeS = txtIme.Text;
                PrezimeS = txtPrezime.Text;
                AdresaS = txtAdresa.Text;
                BrojTelefonaS = Convert.ToInt64(txtTelefon.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ispunite sve podatke", "Nepotpuni podatci",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                exceptionFound = true;
            }

            if (exceptionFound == false) DialogResult = DialogResult.OK;
        }
    }
}
