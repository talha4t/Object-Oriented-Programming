using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_ComboBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryListComboBox.Items.Add("Bangladesh");
            countryListComboBox.Items.Add("Bhutan");
            countryListComboBox.Items.Add("England");
            countryListComboBox.Items.Add("Jamaica");
            countryListComboBox.Items.Add("Russia");
        }

        private void countryListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aCountry = countryListComboBox.SelectedItem.ToString();

            MessageBox.Show(aCountry);
        }
    }
}
