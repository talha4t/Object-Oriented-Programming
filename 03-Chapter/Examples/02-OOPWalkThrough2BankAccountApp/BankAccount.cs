using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough2BankAccountApp
{
    class BankAccount
    {
        public string accountNumber;
        public string holderName;
        public double balance;

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
    }
}
