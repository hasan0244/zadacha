using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine().ToLower();
            char[] i = n.ToCharArray(); 
            Array.Reverse(i);
            string o = new string(i);
            Console.WriteLine(o);
        }
    }
}
