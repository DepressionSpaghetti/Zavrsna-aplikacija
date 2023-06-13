using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsna_aplikacija
{
    public partial class Detalji : Form
    {
        Main a;
        int index, indexVlasnik;
        public Detalji(Main b, int x)
        {
            a = b;
            index = x;
            InitializeComponent();
        }
        

        private void Detalji_Load(object sender, EventArgs e)
        {
            //Plovilo
            lblRegistracija.Text = a.ListaPlovilaGet[index].Registracija;
            lblImePlov.Text = a.ListaPlovilaGet[index].Ime;
            lblSerBr.Text = a.ListaPlovilaGet[index].SerijskiBroj;
            lblDuzina.Text = Convert.ToString(a.ListaPlovilaGet[index].Duzina)+"m";
            lblTezina.Text = Convert.ToString(a.ListaPlovilaGet[index].Tezina)+"bt";
            lblGodReg.Text = Convert.ToString(a.ListaPlovilaGet[index].GodinaRegistracije);
            lblDrzava.Text = a.ListaPlovilaGet[index].DrzavaRegistracije;
            lblVez.Text = a.ListaPlovilaGet[index].Vez;
            pictureBox1.ImageLocation = a.ListaPlovilaGet[index].SlikaPath;
            //Vlasnik
            foreach(Vlasnik v in a.ListaVlasnikaGet)
            {
                if (a.ListaPlovilaGet[index].Vlasnik == v.IDnum) indexVlasnik = a.ListaVlasnikaGet.IndexOf(v);
            }

            lblImePrezime.Text = a.ListaVlasnikaGet[indexVlasnik].Ime + " " + a.ListaVlasnikaGet[indexVlasnik].Prezime;
            lblBrevet.Text = Convert.ToString(a.ListaVlasnikaGet[indexVlasnik].Brevet);
            lblEmail.Text = a.ListaVlasnikaGet[indexVlasnik].Email;
            lblBrMob.Text = Convert.ToString(a.ListaVlasnikaGet[indexVlasnik].BrojMobitela);

        }
    }
}
