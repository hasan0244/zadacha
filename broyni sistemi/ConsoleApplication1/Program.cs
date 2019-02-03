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
            var n = int.Parse(Console.ReadLine());
            string s = "";
            int r;
            while (n > 0)
            {
                r = n % 16;
                n = n / 16;
                s = s + r.ToString();
            }
            for (int i = s.Length - 1 ; i >= 0; i--)
                Console.Write(s[i]);
            Console.WriteLine();
        }
    }
}
