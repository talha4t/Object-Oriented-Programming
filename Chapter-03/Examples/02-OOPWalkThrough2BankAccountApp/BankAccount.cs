using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOPWalkThrough2BankAccountApp
{
    class BankAccount
    {
        public string accountNumber;
        public string accountHolderName;
        public double balance;

        public void Deposite(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
    }
}
