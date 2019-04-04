using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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
        public int Age2
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }
    }

}
