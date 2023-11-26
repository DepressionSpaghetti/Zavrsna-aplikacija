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
    public partial class DodajKnjigu : Form
    {
        bool exceptionFound = false;
        string naslov, autor, izdavac;
        
        public string Naslov { get => naslov; }
        public string Autor { get => autor; }
        public string Izdavac { get => izdavac; }

        string NaslovS { set => naslov = value; }
        string AutorS { set => autor = value; }
        string IzdavacS { set => izdavac = value; }

        public DodajKnjigu()
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
                NaslovS = txtNaslov.Text;
                AutorS = txtAutor.Text;
                IzdavacS = txtIzdavac.Text;
            }catch(Exception ex)
            {
                MessageBox.Show("Ispunite sve podatke", "Nepotpuni podatci",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                exceptionFound = true;
            }

            if (exceptionFound == false) DialogResult = DialogResult.OK;
        }
    }
}
