using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SolutionOfOOPPractice1
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void showTotalButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.employeeName = employeeNameTextBox.Text;
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show(aSalary.employeeName + ", your total salary is: " + aSalary.GetTotalSalary());

        }
    }
}
