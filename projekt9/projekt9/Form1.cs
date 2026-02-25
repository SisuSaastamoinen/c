using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = vastaus + "Farenheit";
                VastausLB.Visible = true;
            }
            else if (FarenheitRB.Checked)
            {
                vastaus = (asteet * 32) / 1.8;
                VastausLB.Text = vastaus + "Celsius";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Error";
                VastausLB.Visible = true;
            }
        }
    }
}
