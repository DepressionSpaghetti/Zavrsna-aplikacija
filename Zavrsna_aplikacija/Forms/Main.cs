using CsvHelper;
using CsvHelper.Configuration.Attributes;
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
        private Label[] lblImePlovila;
        private Label[] lblImePlovVariable;
        private Label[] lblRegistracija;
        private Label[] lblRegVariable;
        private Label[] lblImeVlasnika;
        private Label[] lblImeVlasVariable;
        private PictureBox[] picBoat;
        private GroupBox[] grpDet;

        int space;
        int i;
        int yOfLastControl;

        List<Plovilo> ListaPlovila = new List<Plovilo>();
        List<Vlasnik> ListaVlasnika = new List<Vlasnik>();

        public Main()
        {
            InitializeComponent();
        }

        private void dodajNoviVezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 0;
            space = 0;
            yOfLastControl = 0;

            NoviVez noviVez = new NoviVez();
            if(noviVez.ShowDialog(Owner) == DialogResult.OK)
            {
                Vlasnik vlasnik = new Vlasnik(noviVez.ImeVlasnik, noviVez.Prezime, noviVez.Email, noviVez.BrojMob, noviVez.Brevet, noviVez.Rnd.Next());
                Plovilo plovilo = new Plovilo(noviVez.Registracija, noviVez.Ime, noviVez.SerijskiBroj, noviVez.Duzina, noviVez.Tezina, noviVez.GodinaReg,
                    noviVez.DrzavaRegistracije, noviVez.Vez, vlasnik.IDnum);
                plovilo.SlikaPath = noviVez.EndFilePath;

                ListaPlovila.Add(plovilo);
                ListaVlasnika.Add(vlasnik);

                if (ListaPlovila.Count == 1) yOfLastControl = 71;
                else
                {
                    yOfLastControl = grpDet[ListaPlovila.Count - 1].Location.Y;

                }

                grpDet = new GroupBox[ListaPlovila.Count];
                picBoat = new PictureBox[ListaPlovila.Count];
                lblImePlovila = new Label[ListaPlovila.Count];
                lblImePlovVariable = new Label[ListaPlovila.Count];
                lblRegistracija = new Label[ListaPlovila.Count];
                lblRegVariable = new Label[ListaPlovila.Count];
                lblImeVlasnika = new Label[ListaPlovila.Count];
                lblImeVlasVariable = new Label[ListaPlovila.Count];

                foreach (Plovilo p in ListaPlovila)
                {
                    string ImeVlasnika = null;
                    foreach (Vlasnik v in ListaVlasnika)
                    {
                        if (v.IDnum == p.Vlasnik) ImeVlasnika = v.Ime;
                    }

                    //groupBox
                    grpDet[i].Controls.Add(picBoat[i]);
                    grpDet[i].Controls.Add(lblImePlovila[i]);
                    grpDet[i].Controls.Add(lblImePlovVariable[i]);
                    grpDet[i].Controls.Add(lblRegistracija[i]);
                    grpDet[i].Controls.Add(lblRegVariable[i]);
                    grpDet[i].Controls.Add(lblImeVlasnika[i]);
                    grpDet[i].Controls.Add(lblImeVlasVariable[i]);
                    grpDet[i] = new GroupBox();
                    grpDet[i].Name = "grpDet" + i;
                    grpDet[i].Location = new System.Drawing.Point(12, yOfLastControl + space);
                    grpDet[i].Size = new System.Drawing.Size(617, 211);
                    grpDet[i].TabStop = false;
                    //PictureBox
                    picBoat[i] = new PictureBox();
                    picBoat[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    picBoat[i].Location = new System.Drawing.Point(6, 19);
                    picBoat[i].Name = "picBoat" + i;
                    picBoat[i].Size = new System.Drawing.Size(182, 176);
                    picBoat[i].SizeMode = PictureBoxSizeMode.Zoom;
                    picBoat[i].TabStop = false;
                    picBoat[i].ImageLocation = p.SlikaPath;
                    picBoat[i].ErrorImage = global::Zavrsna_aplikacija.Properties.Resources.coconut;
                    //Label Ime plovila
                    lblImePlovila[i] = new Label();
                    lblImePlovila[i].Location = new System.Drawing.Point(552, 94);
                    lblImePlovila[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblImePlovila[i].Name = "lblImePlovila" + i;
                    lblImePlovila[i].Size = new System.Drawing.Size(120, 25);
                    lblImePlovila[i].Text = "Ime plovila:";
                    //Label Ime plovila variable
                    lblImePlovVariable[i] = new Label();
                    lblImePlovVariable[i].Location = new System.Drawing.Point(804, 94);
                    lblImePlovVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblImePlovVariable[i].Name = "lblImePlovVariable" + i;
                    lblImePlovVariable[i].AutoSize = true;
                    lblImePlovVariable[i].Text = p.Ime;
                    //Label registracija
                    lblRegistracija[i] = new Label();
                    lblRegistracija[i].Location = new System.Drawing.Point(552, 177);
                    lblRegistracija[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblRegistracija[i].Name = "lblRegistracija" + i;
                    lblRegistracija[i].Size = new System.Drawing.Size(199, 25);
                    lblRegistracija[i].Text = "Registracija plovila:";
                    //Label registracija variable
                    lblRegVariable[i] = new Label();
                    lblRegVariable[i].Location = new System.Drawing.Point(804, 177);
                    lblRegVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblRegVariable[i].Name = "lblRegVariable" + i;
                    lblRegVariable[i].AutoSize = true;
                    lblRegVariable[i].Text = p.Registracija;
                    //Label Ime vlasnika
                    lblImeVlasnika[i] = new Label();
                    lblImeVlasnika[i].Location = new System.Drawing.Point(552, 262);
                    lblImeVlasnika[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblImeVlasnika[i].Name = "lblImeVlasnika" + i;
                    lblRegVariable[i].Size = new System.Drawing.Size(137, 25);
                    lblRegVariable[i].Text = "Ime vlasnika:";
                    //Label Ime vlasnika variable
                    lblImeVlasVariable[i] = new Label();
                    lblImeVlasVariable[i].Location = new System.Drawing.Point(804, 262);
                    lblImeVlasVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lblImeVlasVariable[i].Name = "lblImeVlasVariable" + i;
                    lblImeVlasVariable[i].AutoSize = true;
                    lblImeVlasVariable[i].Text = ImeVlasnika;

                    i++;
                    space += 458;
                }

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

            if(plovilaLength != 0 && vlasniciLength != 0 && File.Exists(@"db\plovila.csv") && File.Exists(@"db\vlasnici.csv"))
            {
                try
                {
                    using (var readerPlovila = new StreamReader(@"db\plovila.csv"))
                    using (var csvPlovilaRead = new CsvReader(readerPlovila, CultureInfo.InvariantCulture))
                    {
                        ListaPlovila.Add((Plovilo)csvPlovilaRead.GetRecords<Plovilo>());
                    }
                    using (var readerVlasnici = new StreamReader(@"db\vlasnici.csv"))
                    using (var csvVlasniciRead = new CsvReader(readerVlasnici, CultureInfo.InvariantCulture))
                    {
                        ListaVlasnika.Add((Vlasnik)csvVlasniciRead.GetRecords<Vlasnik>());
                    }
                }
                catch (CsvHelperException exception) 
                {
                    MessageBox.Show(Convert.ToString(exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            grpDet = new GroupBox[ListaPlovila.Count];
            picBoat = new PictureBox[ListaPlovila.Count];
            lblImePlovila = new Label[ListaPlovila.Count];
            lblImePlovVariable = new Label[ListaPlovila.Count];
            lblRegistracija = new Label[ListaPlovila.Count];
            lblRegVariable = new Label[ListaPlovila.Count];
            lblImeVlasnika = new Label[ListaPlovila.Count];
            lblImeVlasVariable = new Label[ListaPlovila.Count];

            foreach (Plovilo p in ListaPlovila)
            {
                string ImeVlasnika = null;
                foreach(Vlasnik v in ListaVlasnika)
                {
                    if (v.IDnum == p.Vlasnik) ImeVlasnika = v.Ime;
                }

                //groupBox
                grpDet[i].Controls.Add(picBoat[i]);
                grpDet[i].Controls.Add(lblImePlovila[i]);
                grpDet[i].Controls.Add(lblImePlovVariable[i]);
                grpDet[i].Controls.Add(lblRegistracija[i]);
                grpDet[i].Controls.Add(lblRegVariable[i]);
                grpDet[i].Controls.Add(lblImeVlasnika[i]);
                grpDet[i].Controls.Add(lblImeVlasVariable[i]);
                grpDet[i] = new GroupBox();
                grpDet[i].Name = "grpDet" + i;
                grpDet[i].Location = new System.Drawing.Point(12, 71 + space);
                grpDet[i].Size = new System.Drawing.Size(617, 211);
                grpDet[i].TabStop = false;
                //PictureBox
                picBoat[i] = new PictureBox();
                picBoat[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                picBoat[i].Location = new System.Drawing.Point(6, 19);
                picBoat[i].Name = "picBoat" + i;
                picBoat[i].Size = new System.Drawing.Size(182, 176);
                picBoat[i].SizeMode = PictureBoxSizeMode.Zoom;
                picBoat[i].TabStop = false;
                picBoat[i].ImageLocation = p.SlikaPath;
                picBoat[i].ErrorImage = global::Zavrsna_aplikacija.Properties.Resources.coconut;
                //Label Ime plovila
                lblImePlovila[i] = new Label();
                lblImePlovila[i].Location = new System.Drawing.Point(552, 94);
                lblImePlovila[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblImePlovila[i].Name = "lblImePlovila" + i;
                lblImePlovila[i].Size = new System.Drawing.Size(120, 25);
                lblImePlovila[i].Text = "Ime plovila:";
                //Label Ime plovila variable
                lblImePlovVariable[i] = new Label();
                lblImePlovVariable[i].Location = new System.Drawing.Point(804, 94);
                lblImePlovVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblImePlovVariable[i].Name = "lblImePlovVariable" + i;
                lblImePlovVariable[i].AutoSize = true;
                lblImePlovVariable[i].Text = p.Ime;
                //Label registracija
                lblRegistracija[i] = new Label();
                lblRegistracija[i].Location = new System.Drawing.Point(552, 177);
                lblRegistracija[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblRegistracija[i].Name = "lblRegistracija" + i;
                lblRegistracija[i].Size = new System.Drawing.Size(199, 25);
                lblRegistracija[i].Text = "Registracija plovila:";
                //Label registracija variable
                lblRegVariable[i] = new Label();
                lblRegVariable[i].Location = new System.Drawing.Point(804, 177);
                lblRegVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblRegVariable[i].Name = "lblRegVariable" + i;
                lblRegVariable[i].AutoSize = true;
                lblRegVariable[i].Text = p.Registracija;
                //Label Ime vlasnika
                lblImeVlasnika[i] = new Label();
                lblImeVlasnika[i].Location = new System.Drawing.Point(552, 262);
                lblImeVlasnika[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblImeVlasnika[i].Name = "lblImeVlasnika" + i;
                lblRegVariable[i].Size = new System.Drawing.Size(137, 25);
                lblRegVariable[i].Text = "Ime vlasnika:";
                //Label Ime vlasnika variable
                lblImeVlasVariable[i] = new Label();
                lblImeVlasVariable[i].Location = new System.Drawing.Point(804, 262);
                lblImeVlasVariable[i].Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                lblImeVlasVariable[i].Name = "lblImeVlasVariable" + i;
                lblImeVlasVariable[i].AutoSize = true;
                lblImeVlasVariable[i].Text = ImeVlasnika;

                i++;
                space += 458;
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
