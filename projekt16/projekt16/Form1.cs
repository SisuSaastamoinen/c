using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt16
{
    public partial class Form1 : Form
    {
        private int TotalTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for(int i = 0; i < 60; i ++)
            {
                MinutesCB.Items.Add(i.ToString());
                SecondsCB.Items.Add(i.ToString());
            }
            MinutesCB.SelectedIndex = 0;
            SecondsCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minutes = int.Parse(MinutesCB.SelectedItem.ToString());
            int seconds = int.Parse(SecondsCB.SelectedItem.ToString());
            TotalTime = (minutes * 60) + seconds;
            timer1.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            timer1.Enabled = false;
            TimeLB.Text = "00:00";
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if(TotalTime > 0)
            {
                TotalTime--;
                int minutes = TotalTime / 60;
                int seconds = TotalTime - (minutes * 60);
                TimeLB.Text = minutes + ":" + seconds;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Timer");
            }
        }
    }
}
