using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int nt = 1; nt <= n; nt++)
            {
                int d = nt;
                int s = 0;
                while (d > 0)
                {
                    s += d % 10;
                    d = d / 10;
                }
                bool f = (s == 5 || s == 7 || s == 11);
                Console.WriteLine("{0} -> {1}", nt, f);
            }


        }
    }
}
