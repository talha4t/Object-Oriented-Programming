﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_VariableExample3Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);

            double addResult = number1 + number2;

            MessageBox.Show(number1 + " + " + number2 + " = " + addResult);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);

            double subtractResult = number1 - number2;

            MessageBox.Show(number1 + " - " + number2 + " = " + subtractResult);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);

            double multiplyResult = number1 * number2;

            MessageBox.Show(number1 + " * " + number2 + " = " + multiplyResult);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);

            double divideResult = number1 / number2;

            MessageBox.Show(number1 + " / " + number2 + " = " + divideResult);
        }
    }
}
