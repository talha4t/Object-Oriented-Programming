using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_EmployeePrimitiveType
{
    public partial class EmployeeInfoUI : Form
    {
        private string id;
        private string name;
        private double salary;
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }

        private void saveAndClearButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text;
            name = nameTextBox.Text;
            salary = Convert.ToDouble(salaryTextBox.Text);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void showSavedDataButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = id;
            nameTextBox.Text = name;
            salaryTextBox.Text = salary.ToString();
        }
    }
}
