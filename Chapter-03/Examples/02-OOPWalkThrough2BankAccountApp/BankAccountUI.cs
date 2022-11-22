using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_OOPWalkThrough2BankAccountApp
{
    public partial class BankAccountUI : Form
    {
        BankAccount anAccount;
        public BankAccountUI()
        {
            InitializeComponent();
        }

        private void BankAccountUI_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BankAccount anAccount = new BankAccount();
            anAccount.accountNumber = accountNumberTextBox.Text;
            anAccount.accountHolderName = holderNameTextBox.Text;
            MessageBox.Show("Account has been created.");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Deposite(amount);
            MessageBox.Show(amount + " taka has been deposited.");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Withdraw(amount);
            MessageBox.Show(amount + " taka has been withdrawn.");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string info = anAccount.accountHolderName + "\n"
            + "Account number: " + anAccount.accountNumber + "\n"
            + "Balance: " + anAccount.balance;

            MessageBox.Show(info);
        }
    }
}
