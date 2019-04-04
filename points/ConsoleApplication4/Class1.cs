using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    
        class BankAccount
        {
            private int id;
            

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }
            private double balance;
            public void Deposit(double amount)
            {
                this.balance += amount;
            }
            public void Withdraw(double amount)
            {
                this.balance -= amount;
            }
            public override string ToString()
            {
                return "Account " + id + "balance " + balance;
            }

    }
}
