using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button_by_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        void equal_on_press()
        {   
            int lenght = (textBox1.Text).Length;
            string[] calcText = new string[lenght];
            int arrayPos = 0;
            bool num = true;
            string[] calc = new string[lenght];
            int final_value = 0;
            for (int i = 0; i < lenght; i++)
            {
                calcText[i] = textBox1.Text[i].ToString();
            }

            for (int i = 0; i < lenght; i++)
            {
                if ((calcText[i] == "+") || (calcText[i] == "-") || (calcText[i] == "*") || (calcText[i] == "/"))
                {
                    num = false;
                }
                else
                {
                    num = true;
                }
                if (num)
                {
                    calc[arrayPos] += calcText[i];
                }
                else
                {
                    arrayPos++;
                    calc[arrayPos] += calcText[i];
                    arrayPos++;
                }
            }
            System.Console.WriteLine(calc[0]);
            System.Console.WriteLine(calc[1]);
            System.Console.WriteLine(calc[2]);
            if (calc[1] == "+")
            {
                final_value = Convert.ToInt32(calc[0]) + Convert.ToInt32(calc[2]);
            }
            else if (calc[1] == "-")
            {
                final_value = Convert.ToInt32(calc[0]) - Convert.ToInt32(calc[2]);
            }
            else if (calc[1] == "*")
            {
                final_value = Convert.ToInt32(calc[0]) * Convert.ToInt32(calc[2]);
            }
            else if (calc[1] == "/")
            {
                final_value = Convert.ToInt32(calc[0]) / Convert.ToInt32(calc[2]);
            }
            System.Console.WriteLine(final_value);
            for (int i = 4; i < calc.Length; i+=2)
            {
                if (calc[i] == "+")
                {
                    final_value += Convert.ToInt32(calc[i + 1]);
                }
                else if (calc[i] == "-")
                {
                    final_value -= Convert.ToInt32(calc[i + 1]);
                }
                else if (calc[i] == "*")
                {
                    final_value *= Convert.ToInt32(calc[i + 1]);
                }
                else if (calc[i] == "/")
                {
                    final_value /= Convert.ToInt32(calc[i + 1]);
                }
            }
            label1.Text = final_value.ToString();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            equal_on_press();
        }
    }
}
