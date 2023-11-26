using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace biblioteka
{
    public class Korisnik
    {
        string email, ime, prezime, adresa;
        long brojTelefona, ID;

        public Korisnik(string email, string ime, string prezime, string adresa,
            long brojTelefona)
        {
            this.email = email;
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
        }

        string Email { get => email; set => email = value; }
        string Ime { get => ime; set => ime = value; }
        string Prezime { get => prezime; set => prezime = value; }
        string Adresa { get => adresa; set => adresa = value; }
        long BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
    }

    public class Knjiga
    {
        string naslov, autor, izdavac;
        long knjigaID;

        public Knjiga(string naslov, string autor, string izdavac)
        {
            this.naslov = naslov;
            this.autor = autor;
            this.izdavac = izdavac;
        }

        class Stanje
        {
            int kolicinaKnjiga;
        }
    }

    public class Evidencija
    {
        long knjigaID, korisnikID, evidencijaID;
        DateTime datumPodizanja, datumVracanja;

        public Evidencija(long knjigaID, long korisnikID, DateTime datumPodizanja,
            DateTime datumVracanja)
        {
            this.knjigaID = knjigaID;
            this.korisnikID = korisnikID;
            this.datumPodizanja = datumPodizanja;
            this.datumVracanja = datumVracanja;
        }

        long KnjigaID { get => knjigaID; set => knjigaID = value; }
        long KorisnikID { get => korisnikID; set => korisnikID = value; }
        long EvidencijaID { get => evidencijaID; set => evidencijaID = value; }
        DateTime DatumPodizanja { get => datumPodizanja; set => datumPodizanja = value; }
        DateTime DatumVracanja { get => datumVracanja; set => datumVracanja = value; }
    }
}
