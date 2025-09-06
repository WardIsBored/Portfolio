using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        bool OnNumOne = true;
        string Num1 = "";
        string Num2 = "";
        string Oper = "";
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            Oper = "-";
            OnNumOne = false;
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = Oper;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "1";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "1";
                richTextBox1.Text = Num2;
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "2";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "2";
                richTextBox1.Text = Num2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "3";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "3";
                richTextBox1.Text = Num2;
            }
        }

        private void CA_Click(object sender, EventArgs e)
        {
            Num1 = "";
            Num2 = "";
            Oper = "";
            OnNumOne = true;
            richTextBox1.Text = string.Empty;
        }

        private void FOUR_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "4";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "4";
                richTextBox1.Text = Num2;
            }
        }

        private void FIVE_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "5";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "5";
                richTextBox1.Text = Num2;
            }
        }

        private void SIX_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "6";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "6";
                richTextBox1.Text = Num2;
            }
        }

        private void SEVEN_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "7";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "7";
                richTextBox1.Text = Num2;
            }
        }

        private void EIGHT_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "8";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "8";
                richTextBox1.Text = Num2;
            }
        }

        private void NINE_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "9";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "9";
                richTextBox1.Text = Num2;
            }
        }

        private void ZERO_Click(object sender, EventArgs e)
        {
            if (OnNumOne)
            {
                Num1 += "0";
                richTextBox1.Text = Num1;

            }
            else
            {
                Num2 += "0";
                richTextBox1.Text = Num2;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Oper == "+")
            {
                int intnum1 = Convert.ToInt32(Num1);
                int intnum2 = Convert.ToInt32(Num2);
                int solve = intnum1 + intnum2;
                richTextBox1.Text = string.Empty;
                richTextBox1.Text += solve;
            }
            if (Oper == "-")
            {
                int intnum1 = Convert.ToInt32(Num1);
                int intnum2 = Convert.ToInt32(Num2);
                int solve = intnum1 - intnum2;
                richTextBox1.Text = string.Empty;
                richTextBox1.Text += solve;
            }
            if (Oper == "*")
            {
                int intnum1 = Convert.ToInt32(Num1);
                int intnum2 = Convert.ToInt32(Num2);
                int solve = intnum1 * intnum2;
                richTextBox1.Text = string.Empty;
                richTextBox1.Text += solve;
            }
            if (Oper == "/")
            {
                int intnum1 = Convert.ToInt32(Num1);
                int intnum2 = Convert.ToInt32(Num2);
                int solve = intnum1 / intnum2;
                richTextBox1.Text = string.Empty;
                richTextBox1.Text += solve;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Oper = "*";
            OnNumOne = false;
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = Oper;
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            Oper = "/";
            OnNumOne = false;
            richTextBox1.Text = string.Empty;
            richTextBox1.Text = Oper;
        }
    }
}