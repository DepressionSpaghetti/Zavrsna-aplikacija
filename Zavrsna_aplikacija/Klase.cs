using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija
{
    internal class Klase
    {
        List<Vlasnik> ListaVlasnika = new List<Vlasnik>();
        List<Vozilo> ListaVozila = new List<Vozilo>();

    }

    class Vlasnik
    {
        string ime, prezime, email;
        long broj_mobitela;
        int starost;
        char[] brevet = new char[2];

        public Vlasnik(string ime, string prezime, string email, long broj_mobitela, int starost, char[] brevet)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.broj_mobitela = broj_mobitela;
            this.starost = starost;
            this.brevet = brevet;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public long BrojMobitela { get => broj_mobitela; set => broj_mobitela = value; }
        public int Starost { get => starost; set => starost = value; }
        public char[] Brevet { get => brevet; set => brevet = value; }

    }

    class Vozilo
    {
        string registracija, ime, serijski_broj, drzavaRegistracije;
        int duzina, tezina, godina_registracije;
        char[] vez = new char[2];
        string slikaPath;
        Vlasnik vlasnik;

        public Vozilo(string registracija, string ime, string serijski_broj, int duzina, int tezina, int godina_registracije, char[] vez, Vlasnik vlasnik)
        {
            this.registracija = registracija;
            this.ime = ime;
            this.serijski_broj = serijski_broj;
            this.duzina = duzina;
            this.tezina = tezina;
            this.godina_registracije = godina_registracije;
            this.vez = vez;
            this.vlasnik = vlasnik;
        }
        public string Registracija { get => registracija; set => registracija = value; }
        public string Ime { get => ime; set => ime = value; }
        public string SerijskiBroj { get => serijski_broj; set => serijski_broj = value; }
        public string SlikaPath { get => slikaPath; set => slikaPath = value; }
        public int Duzina { get => duzina; set => duzina = value; }
        public int Tezina { get => tezina; set => tezina = value; }
        public int GodinaRegistracije {  get => godina_registracije; set => godina_registracije = value; }
        public Vlasnik Vlasnik { get => vlasnik; set => vlasnik = value; }

        class Brod
        {
            string tipBroda;

            public Brod(string tipBroda)
            {
                this.tipBroda = tipBroda;
            }

            public string TipBroda { get => tipBroda; set => tipBroda = value; }

        }

        class PomocnaVozila
        {
            string tipVozila;

            public PomocnaVozila(string tipVozila)
            {
                this.tipVozila = tipVozila;
            }

            public string TipVozila { get => tipVozila; set => tipVozila = value; }
        }
    }
}
