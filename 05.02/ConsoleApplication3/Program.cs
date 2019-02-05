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
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", arr)); 
            string[] strings = { "one", "two", "three", "four" };
            Console.WriteLine(string.Join(" - ", strings));
        }
    }
}
