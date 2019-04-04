using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            System.Reflection.FieldInfo[] fields = personType.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            Person firstPerson = new Person();
            Person secondPerson = new Person();
            Person thirdPerson = new Person();
            firstPerson.Name = "Gosho";
            firstPerson.Age = 26;
            secondPerson.Name = "Ivan";
            secondPerson.Age = 34;
            thirdPerson.Name = "Stamat";
            thirdPerson.Age = 38;
            firstPerson.IntroduceYourself();
            secondPerson.IntroduceYourself();
            thirdPerson.IntroduceYourself();
            Console.WriteLine(fields.Length);
        }

    }
}
