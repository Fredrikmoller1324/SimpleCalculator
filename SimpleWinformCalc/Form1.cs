using CalculatorLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleWinformCalc
{
    public partial class Form1 : Form
    {
        private MathSolutions CalcThis = new MathSolutions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        #region buttonclick 0-9
        private void button_1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion

        private void button_EqualResult_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("+") && !richTextBox1.Text.Contains("-") && !richTextBox1.Text.Contains("*") && !richTextBox1.Text.Contains("/"))
            {
                string[] convertedString = richTextBox1.Text.Split('+');
                if (convertedString[0] == "") { convertedString[0] = "0"; }

                richTextBox1.Text = CalcThis.Addition(MathSolutions.AddingFloatsToList(convertedString)).ToString();

            }
            else if (richTextBox1.Text.Contains("-") && !richTextBox1.Text.Contains("+") && !richTextBox1.Text.Contains("*") && !richTextBox1.Text.Contains("/"))
            {
                string[] convertedString = richTextBox1.Text.Split('-');
                if (convertedString[0] == "") { convertedString[0] = "0"; }

                richTextBox1.Text = CalcThis.Substraction(MathSolutions.AddingFloatsToList(convertedString)).ToString();
            }
            else if (richTextBox1.Text.Contains("*") && !richTextBox1.Text.Contains("-") && !richTextBox1.Text.Contains("+") && !richTextBox1.Text.Contains("/"))
            {
                string[] convertedString = richTextBox1.Text.Split('*');
                if (convertedString[0] == "") { convertedString[0] = "0"; }

                richTextBox1.Text = CalcThis.Multiplication(MathSolutions.AddingFloatsToList(convertedString)).ToString();
            }
            else if (richTextBox1.Text.Contains("/") && !richTextBox1.Text.Contains("-") && !richTextBox1.Text.Contains("+") && !richTextBox1.Text.Contains("*"))
            
            {
                string[] convertedString = richTextBox1.Text.Split('/');
                if (convertedString[0] == "") { convertedString[0] = "0"; }

                richTextBox1.Text = CalcThis.Division(MathSolutions.AddingFloatsToList(convertedString)).ToString();
            }
            else
            {
                MessageBox.Show("In this version you can only use one operator a time");
            }

            /*
             * Test med multioperators (work in progress, tar endast single digits )
             * 
             * MathSolutions test = new MathSolutions();
             * string sendToMethod = richTextBox1.Text;
             * richTextBox1.Text = test.AdvancedCalcforWinform(sendToMethod).ToString();
             */
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("+");
        }

        private void button_Substraction_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength <= 0)
            {
                MessageBox.Show("There are no numbers or operators to delete!", "Error");
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.TextLength - 1, 1);
            }
        }

        private void button_NegToPos_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.StartsWith('-'))
            {
                richTextBox1.Text = richTextBox1.Text.Remove(0,1);
            }
            else
            {
                string posToNeg = richTextBox1.Text;

                richTextBox1.Text = posToNeg.Insert(0, "-");
            }
        }

        private void button_commadot_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }

        private void button_Square_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                string numberToSquare = richTextBox1.Text;
                float product = MathF.Pow(float.Parse(numberToSquare), 2);
                richTextBox1.Text = product.ToString();
            }
            
        }
    }
}
