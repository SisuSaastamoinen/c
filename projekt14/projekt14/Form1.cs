using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projekt14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\");
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString() + "\n";
            TextWriter text = new StreamWriter("C:\\");
            text.Write(teksti);
            Application.Exit();
        }
    }
}
