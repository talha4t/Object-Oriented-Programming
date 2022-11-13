﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfPractice1
{
    public partial class LaptopUI : Form
    {
        Laptop aLaptop = new Laptop();
        public LaptopUI()
        {
            InitializeComponent();
        }

        private void saveAndClearButton_Click(object sender, EventArgs e)
        {
            aLaptop.brandName = brandNameTextBox.Text;
            aLaptop.ramSizeInGB = Convert.ToInt32(ramSizeTextBox.Text);
            aLaptop.numberOfCore = Convert.ToInt32(processorCoreNumberTextBox.Text);

            clearTextBox();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            brandNameTextBox.Text = aLaptop.brandName;
            ramSizeTextBox.Text = aLaptop.ramSizeInGB.ToString();
            processorCoreNumberTextBox.Text = aLaptop.numberOfCore.ToString();
        }

        private void clearTextBox()
        {
            brandNameTextBox.Text = "";
            ramSizeTextBox.Text = "";
            processorCoreNumberTextBox.Text = "";
        }
    }
}
