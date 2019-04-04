using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person();
            Person thirdPerson = new Person();
            BankAccount first = new BankAccount();
            BankAccount first2 = new BankAccount();
            BankAccount first3 = new BankAccount();
            BankAccount first4 = new BankAccount();
            firstPerson.Name = "Гошо";
            firstPerson.Age = 46;
            secondPerson.Name = "Иван";
            secondPerson.Age = 34;
            secondPerson.Name = "Mariq";
            secondPerson.Age = 36;
            first.ID = 12243523;
            first.Balance = 444;
            firstPerson.Accounts.Add(first);
            first2.ID = 34632461;
            first2.Balance = 555;
            secondPerson.Accounts.Add(first2);
            first3.ID = 12243523;
            first3.Balance = 444;
            thirdPerson.Accounts.Add(first3);
            first4.ID = 634;
            first4.Balance = 555;
            thirdPerson.Accounts.Add(first4);
            first4.ID = 68532634;
            first4.Balance = 444;
            thirdPerson.Accounts.Add(first4);
            Console.WriteLine(firstPerson.GetBalance());
            Console.WriteLine(secondPerson.GetBalance());
            Console.WriteLine(thirdPerson.GetBalance());


            
        }
    }
}
