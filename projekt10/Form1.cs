using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);
            if(painoindeksi < 18.5)
            {
                VastausLB.Text = painoindeksi + "";
                VastausLB.Visible = true;
                KuvausLB.Text = "Alipaino";
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = painoindeksi + "";
                VastausLB.Visible = true;
                KuvausLB.Text = "Normaalipainopaino";
                KuvausLB.Visible = true;
            }
            else if (painoindeksi < 40)
            {
                VastausLB.Text = painoindeksi + "";
                VastausLB.Visible = true;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.Visible = true;
            }
        }
    }
}
