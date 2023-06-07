using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Zavrsna_aplikacija
{
    public partial class Main : Form
    {
        List<Plovilo> ListaPlovila = new List<Plovilo>();
        List<Vlasnik> ListaVlasnika = new List<Vlasnik>();

        public Main()
        {
            InitializeComponent();
        }

        private void dodajNoviVezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoviVez noviVez = new NoviVez();
            if(noviVez.ShowDialog(Owner) == DialogResult.OK)
            {
                Vlasnik vlasnik = new Vlasnik(noviVez.ImeVlasnik, noviVez.Prezime, noviVez.Email, noviVez.BrojMob, noviVez.Brevet, noviVez.Rnd.Next());
                Plovilo plovilo = new Plovilo(noviVez.Registracija, noviVez.Ime, noviVez.SerijskiBroj, noviVez.Duzina, noviVez.Tezina, noviVez.GodinaReg,
                    noviVez.DrzavaRegistracije, noviVez.Vez, vlasnik.IDnum);
                plovilo.SlikaPath = noviVez.EndFilePath;

                ListaPlovila.Add(plovilo);
                ListaVlasnika.Add(vlasnik);
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {

        }
    }
}
