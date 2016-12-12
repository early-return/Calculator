using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        private string copyString;
        private double preNum = 0;
        private string preOp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void compute(string op)
        {
            string text = textBox1.Text;
            double num = 0;
            if(!text.Equals(""))
            {
                num = double.Parse(text);
                if(!preOp.Equals(""))
                {
                    switch(preOp)
                    {
                        case "+":
                            num += preNum;
                            break;
                        case "-":
                            num = preNum - num;
                            break;
                        case "*":
                            num = preNum * num;
                            break;
                        case "/":
                            num = preNum / num;
                            break;
                        case "^":
                            num = Math.Pow(preNum, num);
                            break;
                        case "log":
                            num = Math.Log(preNum, num);
                            break;
                        case "mod":
                            num = (int)preNum % (int)num;
                            break;
                    }
                }
                preNum = num;
                if (!op.Equals("="))
                {
                    preOp = op;
                    textBox1.Text = "";
                }
                else
                {
                    preOp = "";
                    textBox1.Text = "" + num;
                }
            }
        }

        private void 粘贴AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + copyString;
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyString = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text.Length > 0)
            {
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                textBox1.Text += "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text.Substring(0, 1).Equals("-"))
            {
                textBox1.Text = text.Substring(1, text.Length - 1);
            }
            else
            {
                textBox1.Text = "-" + text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            compute("/");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            compute("*");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            compute("+");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            compute("-");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            compute("=");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Sin(double.Parse(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Cos(double.Parse(textBox1.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Tan(double.Parse(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Log(double.Parse(textBox1.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Pow(double.Parse(textBox1.Text), 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Pow(double.Parse(textBox1.Text), 3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Pow(double.Parse(textBox1.Text), 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compute("^");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            compute("log");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            long result = 1;
            int num = int.Parse(textBox1.Text);
            for (int i = num; i > 0; i--)
            {
                result *= i;
            }
            textBox1.Text = "" + result;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 1.0 / double.Parse(textBox1.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.E;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.PI;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            compute("mod");
        }

        
    }
}
