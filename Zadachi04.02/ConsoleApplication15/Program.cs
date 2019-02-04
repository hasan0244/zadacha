using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = a * 100;
            double c = b * 365.2422;
            double d = c * 24;
            double e = d * 60;
            double f = e * 60;
            double g = f * 100;
            double j = g * 100;
            double m = j * 100;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", a, b, c, d, e, f, g, j, m);

        }
    }
}
