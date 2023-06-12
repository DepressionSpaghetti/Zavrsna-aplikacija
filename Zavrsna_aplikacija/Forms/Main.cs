using CsvHelper;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        //new
        Label lblImePlovilaNew;
        Label lblImePlovVariableNew;
        Label lblRegistracijaNew;
        Label lblRegVariableNew;
        Label lblImeVlasnikaNew;
        Label lblImeVlasVariableNew;
        PictureBox picBoatNew;
        GroupBox grpDetNew;

        int space;
        int i;
        int yOfLastControl;
        string ImeVlasnika = null;

        public int YofLastControl { get => yOfLastControl; set => yOfLastControl = value; }

        List<Plovilo> ListaPlovila = new List<Plovilo>();
        List<Vlasnik> ListaVlasnika = new List<Vlasnik>();

        public Main()
        {
            InitializeComponent();
        }

        private void AddControl()
        {

            if (ListaPlovila[ListaPlovila.Count - 1].Vlasnik == ListaVlasnika[ListaVlasnika.Count - 1].IDnum)
                ImeVlasnika = ListaVlasnika[ListaVlasnika.Count - 1].Ime;
            if (ListaPlovila.Count == 1)
            {
                yOfLastControl = 47;
                space = 0;
            }

            if (ListaPlovila.Count == 1) i = 0;
            else i = ListaPlovila.Count - 1;

            grpDetNew = new GroupBox();
            picBoatNew = new PictureBox();
            lblImePlovilaNew = new Label();
            lblImePlovVariableNew = new Label();
            lblRegistracijaNew = new Label();
            lblRegVariableNew = new Label();
            lblImeVlasnikaNew = new Label();
            lblImeVlasVariableNew = new Label();
            grpDetNew.SuspendLayout();

            //groupBox
            grpDetNew.Controls.Add(picBoatNew);
            grpDetNew.Controls.Add(lblImePlovilaNew);
            grpDetNew.Controls.Add(lblImePlovVariableNew);
            grpDetNew.Controls.Add(lblRegistracijaNew);
            grpDetNew.Controls.Add(lblRegVariableNew);
            grpDetNew.Controls.Add(lblImeVlasnikaNew);
            grpDetNew.Controls.Add(lblImeVlasVariableNew);
            grpDetNew.Name = "grpDet" + i;
            grpDetNew.Location = new System.Drawing.Point(12, yOfLastControl + space);
            grpDetNew.Size = new System.Drawing.Size(617, 211);
            grpDetNew.TabStop = false;
            //PictureBox
            picBoatNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            picBoatNew.Location = new System.Drawing.Point(6, 19);
            picBoatNew.Name = "picBoat" + i;
            picBoatNew.Size = new System.Drawing.Size(182, 176);
            picBoatNew.SizeMode = PictureBoxSizeMode.Zoom;
            picBoatNew.TabStop = false;
            picBoatNew.ImageLocation = ListaPlovila[ListaPlovila.Count - 1].SlikaPath;
            picBoatNew.ErrorImage = global::Zavrsna_aplikacija.Properties.Resources.coconut;
            //Label Ime plovila
            lblImePlovilaNew.Location = new System.Drawing.Point(270, 35);
            lblImePlovilaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImePlovilaNew.Name = "lblImePlovila" + i;
            lblImePlovilaNew.Size = new System.Drawing.Size(60, 13);
            lblImePlovilaNew.Text = "Ime plovila:";
            //Label Ime plovila variable
            lblImePlovVariableNew.Location = new System.Drawing.Point(415, 35);
            lblImePlovVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImePlovVariableNew.Name = "lblImePlovVariable" + i;
            lblImePlovVariableNew.AutoSize = true;
            lblImePlovVariableNew.Text = ListaPlovila[ListaPlovila.Count - 1].Ime;
            //Label registracija
            lblRegistracijaNew.Location = new System.Drawing.Point(270, 90);
            lblRegistracijaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistracijaNew.Name = "lblRegistracija" + i;
            lblRegistracijaNew.Size = new System.Drawing.Size(98, 13);
            lblRegistracijaNew.Text = "Registracija plovila:";
            //Label registracija variable
            lblRegVariableNew.Location = new System.Drawing.Point(415, 90);
            lblRegVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegVariableNew.Name = "lblRegVariable" + i;
            lblRegVariableNew.AutoSize = true;
            lblRegVariableNew.Text = ListaPlovila[ListaPlovila.Count - 1].Registracija;
            //Label Ime vlasnika
            lblImeVlasnikaNew.Location = new System.Drawing.Point(270, 143);
            lblImeVlasnikaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImeVlasnikaNew.Name = "lblImeVlasnika" + i;
            lblImeVlasnikaNew.Size = new System.Drawing.Size(69, 13);
            lblImeVlasnikaNew.Text = "Ime vlasnika:";
            //Label Ime vlasnika variable
            lblImeVlasVariableNew.Location = new System.Drawing.Point(415, 143);
            lblImeVlasVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImeVlasVariableNew.Name = "lblImeVlasVariable" + i;
            lblImeVlasVariableNew.AutoSize = true;
            lblImeVlasVariableNew.Text = ImeVlasnika;

            this.Controls.Add(grpDetNew);
            grpDetNew.ResumeLayout(false);
            i++;
            YofLastControl = grpDetNew.Location.Y;
            space = 234;
        }

        private void StartupControls(Plovilo p, Vlasnik v)
        {
            if (ListaPlovila.Count == 1)
            {
                yOfLastControl = 47;
                space = 0;
            }

            if (ListaPlovila.Count == 1) i = 0;
            else i = ListaPlovila.Count - 1;

            grpDetNew = new GroupBox();
            picBoatNew = new PictureBox();
            lblImePlovilaNew = new Label();
            lblImePlovVariableNew = new Label();
            lblRegistracijaNew = new Label();
            lblRegVariableNew = new Label();
            lblImeVlasnikaNew = new Label();
            lblImeVlasVariableNew = new Label();
            grpDetNew.SuspendLayout();

            ImeVlasnika = null;
            if (v.IDnum == p.Vlasnik) ImeVlasnika = v.Ime;
            

            //groupBox
            grpDetNew.Name = "grpDet" + i;
            grpDetNew.Location = new System.Drawing.Point(12, 47 + space);
            grpDetNew.Size = new System.Drawing.Size(617, 211);
            grpDetNew.TabStop = false;
            grpDetNew.Controls.Add(picBoatNew);
            grpDetNew.Controls.Add(lblImePlovilaNew);
            grpDetNew.Controls.Add(lblImePlovVariableNew);
            grpDetNew.Controls.Add(lblRegistracijaNew);
            grpDetNew.Controls.Add(lblRegVariableNew);
            grpDetNew.Controls.Add(lblImeVlasnikaNew);
            grpDetNew.Controls.Add(lblImeVlasVariableNew);
            //PictureBox
            picBoatNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            picBoatNew.Location = new System.Drawing.Point(6, 19);
            picBoatNew.Name = "picBoat" + i;
            picBoatNew.Size = new System.Drawing.Size(182, 176);
            picBoatNew.SizeMode = PictureBoxSizeMode.Zoom;
            picBoatNew.TabStop = false;
            picBoatNew.ImageLocation = p.SlikaPath;
            picBoatNew.ErrorImage = global::Zavrsna_aplikacija.Properties.Resources.coconut;
            //Label Ime plovila
            lblImePlovilaNew.Location = new System.Drawing.Point(270, 35);
            lblImePlovilaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImePlovilaNew.Name = "lblImePlovila" + i;
            lblImePlovilaNew.Size = new System.Drawing.Size(60, 13);
            lblImePlovilaNew.Text = "Ime plovila:";
            //Label Ime plovila variable
            lblImePlovVariableNew.Location = new System.Drawing.Point(415, 35);
            lblImePlovVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImePlovVariableNew.Name = "lblImePlovVariable" + i;
            lblImePlovVariableNew.AutoSize = true;
            lblImePlovVariableNew.Text = p.Ime;
            //Label registracija
            lblRegistracijaNew.Location = new System.Drawing.Point(270, 90);
            lblRegistracijaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistracijaNew.Name = "lblRegistracija" + i;
            lblRegistracijaNew.Size = new System.Drawing.Size(98, 13);
            lblRegistracijaNew.Text = "Registracija plovila:";
            //Label registracija variable
            lblRegVariableNew.Location = new System.Drawing.Point(415, 90);
            lblRegVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegVariableNew.Name = "lblRegVariable" + i;
            lblRegVariableNew.AutoSize = true;
            lblRegVariableNew.Text = p.Registracija;
            //Label Ime vlasnika
            lblImeVlasnikaNew.Location = new System.Drawing.Point(270, 143);
            lblImeVlasnikaNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImeVlasnikaNew.Name = "lblImeVlasnika" + i;
            lblRegVariableNew.Size = new System.Drawing.Size(69, 13);
            lblRegVariableNew.Text = "Ime vlasnika:";
            //Label Ime vlasnika variable
            lblImeVlasVariableNew.Location = new System.Drawing.Point(415, 143);
            lblImeVlasVariableNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImeVlasVariableNew.Name = "lblImeVlasVariable" + i;
            lblImeVlasVariableNew.AutoSize = true;
            lblImeVlasVariableNew.Text = ImeVlasnika;

            this.Controls.Add(grpDetNew);
            grpDetNew.ResumeLayout(false);
            YofLastControl = grpDetNew.Location.Y;
            i++;
            space = 234;
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

                AddControl();
            }
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {
            Detalji detalji = new Detalji();
            detalji.ShowDialog(Owner);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            i = 0;
            space = 0;

            var plovilaLength = new FileInfo(@"db\plovila.csv").Length;
            var vlasniciLength = new FileInfo(@"db\vlasnici.csv").Length;

            if(plovilaLength > 99 && vlasniciLength > 43 && plovilaLength != 0 && vlasniciLength !=0
                && File.Exists(@"db\plovila.csv") && File.Exists(@"db\vlasnici.csv"))
            {
                try
                {
                    using (var readerPlovila = new StreamReader(@"db\plovila.csv"))
                    using (var csvPlovilaRead = new CsvReader(readerPlovila, CultureInfo.InvariantCulture))
                    {
                        csvPlovilaRead.Context.RegisterClassMap<PloviloMap>();

                        var records = csvPlovilaRead.GetRecords<Plovilo>();
                        foreach(var record in records)
                        {
                            ListaPlovila.Add(record);
                        }

                    }
                    using (var readerVlasnici = new StreamReader(@"db\vlasnici.csv"))
                    using (var csvVlasniciRead = new CsvReader(readerVlasnici, CultureInfo.InvariantCulture))
                    {
                        csvVlasniciRead.Context.RegisterClassMap<VlasnikMap>();
                        
                        var records1 = csvVlasniciRead.GetRecords<Vlasnik>();
                        foreach(var record1 in records1)
                        {
                            ListaVlasnika.Add(record1);
                        }
                    }
                } catch (CsvHelperException exception) { } 
            
                foreach(Plovilo p in ListaPlovila)
                {
                    StartupControls(p, ListaVlasnika[ListaPlovila.IndexOf(p)]);
                }
            }


        }


        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            //upis u csv
            using (var writerPlovila = new StreamWriter(@"db\plovila.csv"))
            using (var csvPlovila = new CsvWriter(writerPlovila, CultureInfo.InvariantCulture))
            {
                csvPlovila.WriteRecords(ListaPlovila);
            }
            using (var writerVlasnici = new StreamWriter(@"db\vlasnici.csv"))
            using (var csvVlasnici = new CsvWriter(writerVlasnici, CultureInfo.InvariantCulture))
            {
                csvVlasnici.WriteRecords(ListaVlasnika);
            }

        }
    }
}
