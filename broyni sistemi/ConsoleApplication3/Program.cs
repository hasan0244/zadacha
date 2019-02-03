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
            int n = 0, r = 0;
            int s;
            s = int.Parse(Console.ReadLine());
            while (s > 0)
            {
                r = r + (int)(s % 10 * Math.Pow(16, n));
                n++;
                s /= 10;
            }
            Console.WriteLine(r);
            
        }
    }
}
