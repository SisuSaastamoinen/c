using System;
using System.Windows.Forms;

namespace projekt12.alt2
{
    public partial class Form1 : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];

        public Form1()
        {
            InitializeComponent();
            Vastaus1RB.Checked = false;
            Vastaus2RB.Checked = false;
            Vastaus3RB.Checked = false;
            Vastaus4RB.Checked = false;
            KysymysLB.Text = "Vastaus 1 kysymykseen:";
            Vastaus1RB.Click += new EventHandler(RadioButton_Click);
            Vastaus2RB.Click += new EventHandler(RadioButton_Click);
            Vastaus3RB.Click += new EventHandler(RadioButton_Click);
            Vastaus4RB.Click += new EventHandler(RadioButton_Click);
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton radiobutton && radiobutton.Checked)
            {
                vastaukset[laskuri] = radiobutton.Text;
                laskuri++;

                Vastaus1RB.Click -= RadioButton_Click;
                Vastaus2RB.Click -= RadioButton_Click;
                Vastaus3RB.Click -= RadioButton_Click;
                Vastaus4RB.Click -= RadioButton_Click;
                Vastaus1RB.Checked = false;
                Vastaus2RB.Checked = false;
                Vastaus3RB.Checked = false;
                Vastaus4RB.Checked = false;
                Vastaus1RB.Click += RadioButton_Click;
                Vastaus2RB.Click += RadioButton_Click;
                Vastaus3RB.Click += RadioButton_Click;
                Vastaus4RB.Click += RadioButton_Click;

                if (laskuri == 10)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (vastaukset[j] == oikeatVastaukset[j])
                            oikein++;
                    }
                    Vastaus1RB.Enabled = false;
                    Vastaus2RB.Enabled = false;
                    Vastaus3RB.Enabled = false;
                    Vastaus4RB.Enabled = false;
                    KysymysLB.Visible = false;
                    VastausLB.Text = "Oikein: " + oikein + "/10";
                    VastausLB.Visible = true;
                }
                else
                {
                    KysymysLB.Text = "Vastaus " + (laskuri + 1) + " kysymykseen:";
                }
            }
        }
    }
}
