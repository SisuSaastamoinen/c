using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Sisu" && SalasanaTB.Text == "Salasana")
            {
                SalasanaPanel.Visible = false;
                WelcomePanel.Visible = true;
            }
            else
            {
                ErrorLB.Visible = true;
            }
        }
    }
}
