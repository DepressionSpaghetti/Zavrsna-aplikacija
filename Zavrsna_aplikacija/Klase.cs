using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija
{

    class Vlasnik
    {
        long ID;
        string ime, prezime, email;
        long broj_mobitela;
        char brevet;

        public Vlasnik(string ime, string prezime, string email, long broj_mobitela, char brevet, long ID)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.broj_mobitela = broj_mobitela;
            this.brevet = brevet;
            this.ID = ID;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public long BrojMobitela { get => broj_mobitela; set => broj_mobitela = value; }
        public char Brevet { get => brevet; set => brevet = value; }
        public long IDnum { get => ID; }

    }

    class Plovilo
    {
        string registracija, ime, serijski_broj, drzavaRegistracije;
        int duzina, tezina, godina_registracije;
        char[] vez = new char[2];
        string slikaPath;
        long vlasnikID;

        public Plovilo(string registracija, string ime, string serijski_broj, int duzina, int tezina, int godina_registracije, string drzavaRegistracije, char[] vez, long vlasnikID)
        {
            this.registracija = registracija;
            this.ime = ime;
            this.serijski_broj = serijski_broj;
            this.duzina = duzina;
            this.tezina = tezina;
            this.godina_registracije = godina_registracije;
            this.drzavaRegistracije = drzavaRegistracije;
            this.vez = vez;
            this.vlasnikID = vlasnikID;
        }
        public string Registracija { get => registracija; set => registracija = value; }
        public string Ime { get => ime; set => ime = value; }
        public string SerijskiBroj { get => serijski_broj; set => serijski_broj = value; }
        public string DrzavaRegistracije { get => drzavaRegistracije; set => drzavaRegistracije = value; }
        public string SlikaPath { get => slikaPath; set => slikaPath = value; }
        public int Duzina { get => duzina; set => duzina = value; }
        public int Tezina { get => tezina; set => tezina = value; }
        public int GodinaRegistracije {  get => godina_registracije; set => godina_registracije = value; }
        public long Vlasnik { get => vlasnikID; }

    }

    sealed class VlasnikMap : ClassMap<Vlasnik>
    {
        public VlasnikMap() 
        {
            Map(m => m.Ime).Name("Ime");
            Map(m => m.Prezime).Name("Prezime");
            Map(m => m.Email).Name("Email");
            Map(m => m.BrojMobitela).Name("BrojMobitela");
            Map(m => m.Brevet).Name("Brevet");
            Map(m => m.IDnum).Name("IDnum");
        }
    }

    sealed class PloviloMap : ClassMap<Plovilo>
    {
        public PloviloMap()
        {
            Map(m => m.Registracija).Name("Registracija");
            Map(m => m.Ime).Name("Ime");
            Map(m => m.SerijskiBroj).Name("SerijskiBroj");
            Map(m => m.DrzavaRegistracije).Name("DrzavaRegistracije");
            Map(m => m.SlikaPath).Name("SlikaPath");
            Map(m => m.Duzina).Name("Duzina");
            Map(m => m.Tezina).Name("Tezina");
            Map(m => m.GodinaRegistracije).Name("GodinaRegistracije");
            Map(m => m.Vlasnik).Name("Vlasnik");
        }
    }
}
