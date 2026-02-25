using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }
        private void LukuTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void LukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (LukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(LukuTB.Text));
                    LukuTB.Text = "";
                }
            }
        }

        
    }
}
