using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsna_aplikacija
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!Directory.Exists("db" )) Directory.CreateDirectory("db");
            if (!File.Exists(@"db\vlasnici.csv")) File.Create(@"db\vlasnici.csv");
            if (!File.Exists(@"db\plovila.csv")) File.Create(@"db\plovila.csv");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
