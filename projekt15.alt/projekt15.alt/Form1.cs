using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projekt15.alt
{
    public partial class Form1 : Form
    {
        private Stopwatch StopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            TimeLB.Text = StopWatch.Elapsed.ToString();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StopWatch.Stop();
        }

        private void NullBT_Click(object sender, EventArgs e)
        {
            StopWatch.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopWatch = new Stopwatch();
        }
    }
}
