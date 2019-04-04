using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string email;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Employee(string name, decimal salary, string position, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.email = email;
            this.age = age;

        }
    }
}
