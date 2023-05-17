using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zavrsna_aplikacija.Properties;

namespace Zavrsna_aplikacija
{
    public partial class NoviVez : Form
    {

        public NoviVez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                //add filepath to string here
                btnSlika.Hide();
            }
        }

        private void txtRegistracija_Clicked(object sender, EventArgs e)
        {
            txtRegistracija.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
