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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dodajNoviVezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoviVez noviVez = new NoviVez();

            if(noviVez.ShowDialog(Owner) == DialogResult.OK)
            {

            }
        }
    }
}
