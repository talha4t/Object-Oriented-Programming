using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_ListBoxWindowsFormExample
{
    public partial class Form1 : Form
    {
        string outputFormat = "{0, -20}\t{1, -20}";
        public Form1()
        {
            InitializeComponent();
            personInfoListBox.Items.Add(string.Format(outputFormat, "Name", "Contact"));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contact = contactNoTextBox.Text;
            personInfoListBox.Items.Add(string.Format(outputFormat, name, contact));

            nameTextBox.Text = "";
            contactNoTextBox.Text = "";
        }

        private void personInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personInfoListBox.Items.Clear();
        }
    }
}
