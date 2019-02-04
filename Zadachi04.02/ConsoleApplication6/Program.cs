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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double p = a * 2 + b * 2;
            double s = a * b;
            decimal d =(decimal) Math.Sqrt(a * a + b * b);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(d);
        }
    }
}
