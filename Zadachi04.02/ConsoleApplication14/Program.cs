using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
        string a=Console.ReadLine();
        double b = double.Parse(Console.ReadLine());
        if (a == "miles")
        {
            string d = "kilometers";
            double c = b * 1.6;
            Console.WriteLine("{0} {1} = {2 } {3}", a, b, Math.Round(c, 2), d);
        }
        if (a == "inches")
        {
            string d = "centimeters";
            double c = b * 2.54;
            Console.WriteLine("{0} {1} = {2 } {3}", a, b, Math.Round(c, 2), d);
        }
        if (a == "feet")
        {
            string d = "centimeters";
            double c = b * 30;
            Console.WriteLine("{0} {1} = {2 } {3}", a, b, Math.Round(c, 2), d);
        }
        if (a == "yards")
        {
            string d = "meters";
            double c = b * 0.91;
            Console.WriteLine("{0} {1} = {2 } {3}", a, b, Math.Round(c, 2), d);
        }
        if (a == "gallons")
        {
            string d = "liters";
            double c = b * 3.8;
            Console.WriteLine("{0} {1} = {2 } {3}", a, b, Math.Round(c,2) ,d);
        }
        }
    }
}
