using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Person
    {
        private string name;
        private int age;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        private List<BankAccount> accounts = new List<BankAccount>();
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }
    }
}
