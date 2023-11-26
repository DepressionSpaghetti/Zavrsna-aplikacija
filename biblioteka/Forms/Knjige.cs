using System;
using biblioteka;
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
    public partial class Knjige : Form
    {
        List<Knjiga> KnjigeList = new List<Knjiga>();

        //controls setup
        #region
        Label lblNas;
        Label lblAut;
        Label lblIzd;
        Label lblNaslov;
        Label lblAutor;
        Label lblIzdavac;
        GroupBox grpDetNew;
        int space, i, yOfLastControl;
        public int YofLastControl { get => yOfLastControl; set => yOfLastControl = value; }
        #endregion


        public Knjige()
        {
            InitializeComponent();
            foreach(Knjiga k in Pocetna.KnjigaList)
            {
                KnjigeList.Add(k);
            }
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            if(KnjigeList.Count == 1) yOfLastControl = 
            i = 0;
            space = 0;
            YofLastControl = 47;

            foreach(Knjiga k in KnjigeList)
            {
                space = 0;
                if (i == 0) space = 0;
                else space = 129;
            }
        }

    }
}
