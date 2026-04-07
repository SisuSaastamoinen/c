using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text = "9:00 - 14:30 ma, to, pe \n";
            meistaLB.Text = "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text = "juomien lisäksi pientä purtavaa ja makeisia \n";
            meistaLB.Text = "Tervettuloa tutustumaan!\n";
            meistaLB.Font = new Font("Ariel", 12);
        }

        private void meistäBT_Click(object sender, EventArgs e)
        {
            meistäPL.Visible = true;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void ruuatBT_Click(object sender, EventArgs e)
        {
            meistäPL.Visible = false;
            ruuatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistäPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistäPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistäPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }
    }
}
