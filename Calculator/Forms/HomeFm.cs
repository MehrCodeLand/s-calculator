using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    public partial class HomeFm : Form
    {
        private double number1 = 0 ;
        private double number2 = 0 ;
        private string oprator = "NULL";
        public HomeFm()
        {
            InitializeComponent();
            mainBox.Text = "1";
        }


        // number section
        private void button1_Click(object sender, EventArgs e)
        {
            if(mainBox.Text == "0" || mainBox.Text == null )
                mainBox.Text = "1" ;
            else
                mainBox.Text = mainBox.Text + "1" ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "2" ;
            else
                mainBox.Text = mainBox.Text + "2" ;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "3";
            else
                mainBox.Text = mainBox.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "4")
                mainBox.Text = "4";
            else
                mainBox.Text = mainBox.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "5";
            else
                mainBox.Text = mainBox.Text + "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "6";
            else
                mainBox.Text = mainBox.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "7";
            else
                mainBox.Text = mainBox.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "8";
            else
                mainBox.Text = mainBox.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (mainBox.Text == null || mainBox.Text == "0")
                mainBox.Text = "9";
            else
                mainBox.Text = mainBox.Text + "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if(mainBox.Text == null || mainBox.Text == "0")
            {
                
            }
            else
            {
                mainBox.Text = mainBox.Text + "0" ;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            mainBox.Text = "0";
            oprator = "*";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            mainBox.Text = "0";
            oprator = "+";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if(mainBox.Text == null || mainBox.Text == "")
            {
                mainBox.Text = "0";
            }
            number2 = Convert.ToDouble(mainBox.Text);
            Calculate(number1, number2);
        }


        private void Calculate( double num1 , double num2)
        {
            if(oprator == "*")
            {
                mainBox.Text = (num1 * num2).ToString();
            }
            else if(oprator == "+")
            {
                mainBox.Text = (num1 + num2).ToString();
            }else if(oprator == "-")
            {
                mainBox.Text = (num1 - num2).ToString();
            }else if(oprator == "/")
            {
                if (num2 <= 0)
                {
                    mainBox.Text = "0";

                    var message = "divide ZERO Erorr!";
                    MessageBox.Show(message);
                }
                else
                {
                    mainBox.Text = (num1 / num2).ToString();
                }
            }else if(oprator == "%")
            {
                if(num2 <= 0)
                {
                    mainBox.Text = "0";

                    var message = "divide ZERO Erorr!";
                    MessageBox.Show(message);
                }
                else
                {
                    mainBox.Text = (num1 % num2).ToString();
                }
            }else if(oprator == "^")
            {
                mainBox.Text = (Math.Pow(num1, num2)).ToString();
            }else if(oprator == "!")
            {
                mainBox.Text = Factorial(num1).ToString();
            }else if(oprator == "log")
            {
                if(num2 <= 0)
                {
                    var message = "base ZERO!";
                    MessageBox.Show(message);
                }
                else
                {
                   mainBox.Text = Math.Log(num1,num2).ToString();
                }
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            mainBox.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "-";
            mainBox.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "/";
            mainBox.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "%";
            mainBox.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "^";
            mainBox.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "!";
            mainBox.Text = "0";
        }

        private double Factorial(double number)
        {
            double fSum = 1;
            for(int i = 1; i <= number; i++)
            {
                fSum *= i;
            }

            return fSum;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(mainBox.Text);
            oprator = "log";
            mainBox.Text = "0";
        }

        private void MehrCodeLand_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/MehrCodeLand";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);
        }
    }
}
