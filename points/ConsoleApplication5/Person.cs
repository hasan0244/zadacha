using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Person
    {
         public string name;
        public int age;
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
        public void IntroduceYourself()
        {
            Console.WriteLine("{0}-{1}", name, age);
        }
    }
}
