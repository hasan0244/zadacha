using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>(); // създава списък от низове
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            foreach (var name in names)
                Console.WriteLine(name); 
            names.RemoveAt(2);
            Console.WriteLine(String.Join(", ", names));

        }
    }
}
