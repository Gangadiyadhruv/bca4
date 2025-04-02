using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paractical_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void In_number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void In_number1_KeyPress(object sender, KeyPressEventArgs e)
        {
            In_number1.ForeColor = Color.Black;
            In_number1.BackColor = Color.Azure;
        }

        private void In_number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(In_number1.Text);
            int v2 = Convert.ToInt32(In_number2.Text);
            textBox3.Text = (v1 + v2).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(In_number1.Text);
            int v2 = Convert.ToInt32(In_number2.Text);
            textBox3.Text = (v1 - v2).ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(In_number1.Text);
            int v2 = Convert.ToInt32(In_number2.Text);
            textBox3.Text = (v1 * v2).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(In_number1.Text);
            int v2 = Convert.ToInt32(In_number2.Text);
            textBox3.Text = (v1 / v2).ToString();
        }

        private void In_number2_MouseHover(object sender, EventArgs e)
        {
            In_number2.ForeColor = Color.Cyan;
            In_number2.BackColor = Color.DarkOrange;
        }

        private void In_number2_MouseLeave(object sender, EventArgs e)
        {

            In_number2.ForeColor = Color.Black;
            In_number2.BackColor = Color.Gold;
        }
    }
}
