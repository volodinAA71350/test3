using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = " ";
            }
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result;
            result = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                result = dn1 + dn2;
            }
            if (D == "-")
            {
                result = dn1 - dn2;
            }
            if (D == "*")
            {
                result = dn1 * dn2;
            }
            if (D == "/")
            {
                result = dn1 / dn2;
            }
            textBox1.Text = result.ToString();
        }
    }
}
