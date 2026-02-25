using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt8.alt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(NumeroTB.Text, out number))
            {
                if (number > 0 && number < 4000)
                {
                    VastausLB.Text = MuunnaRoomalaiseksi(number);
                    VastausLB.Visible = true;
                }
                else
                {
                    MessageBox.Show("Anna luku väliltä 1–3999");
                }
            }
            else
            {
                MessageBox.Show("Anna kelvollinen numero");
            }
        }
        private string MuunnaRoomalaiseksi(int number)
        {
            string[] tuhannet = { "", "M", "MM", "MMM" };
            string[] sadat = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] kymmenet = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ykkoset = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return tuhannet[number / 1000] +
                   sadat[(number % 1000) / 100] +
                   kymmenet[(number % 100) / 10] +
                   ykkoset[number % 10];
        }
    }
}
