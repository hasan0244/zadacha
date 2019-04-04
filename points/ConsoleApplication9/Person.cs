using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public String FirstName
        {
            get { return this.firstName; }
            
        }
        public int Age
        {
            get { return this.age; }
          
        }
        public String LastName
        {
            get { return this.lastName; }

        }
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.age;
        }
    }
}
