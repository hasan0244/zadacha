using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double t = h * 3600 + m * 60 + s;
            double ms = n / t;
            double kmh = (n / 1000) / (t / 3600);
            double mh = (n / 1609) / (t / 1609);
            Console.WriteLine("{0:f6}",ms);
           
        }
    }
}
