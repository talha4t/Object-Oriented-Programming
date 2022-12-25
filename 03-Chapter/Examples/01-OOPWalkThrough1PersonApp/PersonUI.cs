using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_OOPWalkThrough1PersonApp
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetFullReverseName();
        }
    }
}
