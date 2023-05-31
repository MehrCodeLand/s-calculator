using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    public partial class HomeFm : Form
    {
        private int number1 = 0 ;
        public HomeFm()
        {
            InitializeComponent();
        }


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



    }
}
