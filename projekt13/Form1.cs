using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C: \\Users\\sasti\\source\\repos\\projekt1\\projekt13\\Pojat.txt");
            string[] tytöt = File.ReadAllLines("C:\\Users\\sasti\\source\\repos\\projekt1\\projekt13\\Tytöt.txt");
            string nimi = NimiTB.Text;
            foreach(string poju in pojat)
            {
                if(nimi == poju)
                {
                    VastausLB.Text = "Nimi on suosittu";
                    VastausLB.Visible = true;
                }
            }
            foreach (string girls in tytöt)
            {
                if (nimi == girls)
                {
                    VastausLB.Text = "Nimi on suosittu";
                    VastausLB.Visible = true;
                }
            }
            if(NimiTB.Visible == false)
            {
                VastausLB.Text = "Nimi ei ole suosittu";
                VastausLB.Visible = true;
            }
        }
    }
}
