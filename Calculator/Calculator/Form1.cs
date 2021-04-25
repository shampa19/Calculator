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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
     

        double  num1, result;
        string type;
        int count = 0;
        int numofadd = 0;


        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged( object sender, EventArgs e)
        {

        
        }
        public void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0; 
        }

        private void add_Click(object sender, EventArgs e)
        {

            num1 = Double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            type = "add";
            count = 0;


        }





        private void sub_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            type = "sub";
            count = 0;

        }

        private void divide_Click(object sender, EventArgs e)
        {

            num1 = Double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            type = "div";
            count = 0;

        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            type = "mul";
            count = 0;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case "add":
                    result = num1 + Double.Parse(textBox.Text);
                    textBox.Text = Convert.ToString(result);
                    break;

                case "sub":
                    result = num1 - Double.Parse(textBox.Text);
                    textBox.Text = Convert.ToString(result);
                    break;
                case "mul":
                    result = num1 * Double.Parse(textBox.Text);
                    textBox.Text = Convert.ToString(result);
                    break;

                case "div":
                    result = num1 / Double.Parse(textBox.Text);
                    textBox.Text = Convert.ToString(result);
                    break;


            }
          

        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (count<1)
            {
                textBox.Text = textBox.Text + ".";
                count++;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox.Focus();
            type = "";
        }
    }
}
