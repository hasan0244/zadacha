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
    string s = Console.ReadLine();
    Console.WriteLine(Convert.ToInt32(s, 2).ToString("X"));
        }
    }
}
