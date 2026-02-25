using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(NesteetTB.Text);
            pesut = Convert.ToDouble(PesuTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(PolttoaineTB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + kilometrit + energia) / (kilometrit / 12);
            VastausLB.Text = "" + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
