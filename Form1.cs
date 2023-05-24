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
            float final_value = 0;

            for (int i = 0; i < lenght; i++)
            {
                calcText[i] = textBox1.Text[i].ToString();
            }


            for (int i = 0; i < lenght; i++)
            {
                if ((calcText[i] == "+") || (calcText[i] == "-") || (calcText[i] == "*") || (calcText[i] == "/") || (calcText[i] == "√") || (calcText[i] == "!"))
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
            if (calc[1] == "+")
            {
                final_value = Convert.ToSingle(calc[0]) + Convert.ToSingle(calc[2]);
            }
            else if (calc[1] == "-")
            {
                final_value = Convert.ToSingle(calc[0]) - Convert.ToSingle(calc[2]);
            }
            else if (calc[1] == "*")
            {
                final_value = Convert.ToSingle(calc[0]) * Convert.ToSingle(calc[2]);
            }
            else if (calc[1] == "/")
            {
                final_value = Convert.ToSingle(calc[0]) / Convert.ToSingle(calc[2]);
            }
            else if (calc[0] == "√")
            {
                final_value = Convert.ToSingle(Math.Sqrt(Convert.ToDouble(calc[1])));
            }
            else if (calc[1] == "!")
            {
                final_value = Convert.ToSingle(calc[0]);
                for (int i = Convert.ToInt32(final_value-1); i > 0; i--)
                {
                    final_value *= i;
                }
            }


            for (int i = 4; i < calc.Length; i+=2)
            {
                if (calc[i] == "+")
                {
                    final_value += Convert.ToSingle(calc[i + 1]);
                }
                else if (calc[i] == "-")
                {
                    final_value -= Convert.ToSingle(calc[i + 1]);
                }
                else if (calc[i] == "*")
                {
                    final_value *= Convert.ToSingle(calc[i + 1]);
                }
                else if (calc[i] == "/")
                {
                    final_value /= Convert.ToSingle(calc[i + 1]);
                }
            }


            label1.Text = final_value.ToString();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            equal_on_press();
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button_del_all_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button_del_last_Click(object sender, EventArgs e)
        {
            string[] text = new string[textBox1.Text.Length];
            string first_text = textBox1.Text;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                text[i] = first_text[i].ToString();
            }
            text[first_text.Length-1] = "";
            textBox1.Text = "";
            for (int i = 0; i < text.Length; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void button_radical_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            textBox1.Text += "!";
        }
    }
}
