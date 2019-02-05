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
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int[] inv = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                inv[n - i - 1] = num[i];
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(inv[i]);


        }
    }
}
