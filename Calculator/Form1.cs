using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Cal_Form : Form
    {
        public Cal_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            string w = Output.Text.ToString();
            int len = w.Length;
            bool hasDecimal = false;

            // Check if output already has a decimal
            for (int i = 0; i < len; i ++)
            {
                if (w[i] == '.')
                {
                    hasDecimal = true;
                }
            }

            // Add decimal if not already in string
            if (!hasDecimal)
            {
                Output.Text += "."; 
            }
        }
    }
}
