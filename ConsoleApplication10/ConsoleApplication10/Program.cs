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
            var N = int.Parse(Console.ReadLine());
            while (N > 0)
            {
                int length = int.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long lengthwing = long.Parse(Console.ReadLine());
                var years = (length * length) * (width + 2 * lengthwing);
                Console.WriteLine(years);
                N--;
            }


        }
    }
}
