using biblioteka.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Pocetna : Form
    {
        List<Knjiga> knjigaList = new List<Knjiga>();
        List<Korisnik> korisnikList = new List<Korisnik>();

        static public List<Knjiga> KnjigaList { get => knjigaList; }
        static public List<Korisnik> KorisnikList { get => korisnikList; }

        public Pocetna()
        {
            InitializeComponent();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKorisnika noviKorisnik = new DodajKorisnika();

            if(noviKorisnik.ShowDialog(Owner) == DialogResult.OK)
            {
                Korisnik korisnik = new Korisnik(noviKorisnik.Email, noviKorisnik.Ime,
                    noviKorisnik.Prezime, noviKorisnik.Adresa, noviKorisnik.BrojTelefona);

                korisnikList.Add(korisnik);
            }
        }

        private void dodajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKnjigu novaKnjiga = new DodajKnjigu();

            if (novaKnjiga.ShowDialog(Owner) == DialogResult.OK)
            {
                Knjiga knjiga = new Knjiga(novaKnjiga.Naslov, novaKnjiga.Autor, novaKnjiga.Izdavac);

                knjigaList.Add(knjiga);
            }
        }
    }
}
