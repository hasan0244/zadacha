using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

    string s = Console.ReadLine();
    Console.WriteLine(Convert.ToString(Convert.ToInt32(s, 16), 2));
        }
    }
}
