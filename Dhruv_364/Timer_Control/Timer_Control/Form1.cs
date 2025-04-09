using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t = 0;
        int t2 = 1;
        int t3 = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = t++.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = 0;
            int t2 = 1;
            int t3 = 1;

            label1.Text = t.ToString();
            minute.Text = t2.ToString();
            Second.Text = t3.ToString();

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            minute.Text = t3++.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Second.Text = t2++.ToString();
        }
    }
}
