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
            var d = n * 100;
            var f = d * 365;
            var k = f * 24;
            var t = k * 60;
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(k);
            Console.WriteLine(t);
        }
    }
}
