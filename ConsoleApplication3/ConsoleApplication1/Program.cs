using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRootPrecalculator.GetSqrt(a));
            }

        }
    }
}
