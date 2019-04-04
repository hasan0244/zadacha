using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family myFamily = new Family();
            for (int i = 1; i <= n; i++)
            {
                var line = Console.ReadLine().Split();
                var person = new Person();
                person.Name = line[0];
                person.Age = int.Parse(line[1]);
                myFamily.Peoples.Add(person);
            }
            
            myFamily.Print();

        }
    }
}
