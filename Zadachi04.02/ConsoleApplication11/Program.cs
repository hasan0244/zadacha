using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool b=Convert.ToBoolean(s);
            if (b == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
