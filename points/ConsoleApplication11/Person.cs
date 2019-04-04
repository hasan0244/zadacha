using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person(string firstName1, string lastName1, int age1)
        {
            this.firstName = firstName1;
            this.lastName = lastName1;
            this.age = age1;
        }
        public Person(string firstName1, string lastName1, int age1, decimal salary1)
            : this(firstName1, lastName1, age1)
        {
            this.salary = salary1;
        }
        public string FirstName
        {
            get { return this.firstName; }

        }
        public string LastName
        {
            get { return this.LastName; }

        }
        public int Age
        {
            get { return this.age; }

        }
        public override string ToString()
        {
            return firstName + " " + lastName + " receives " + salary + " leva.";
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age > 30) salary += salary * percentage / 100;
            else salary += salary * percentage / 200;


        }

    }
}
