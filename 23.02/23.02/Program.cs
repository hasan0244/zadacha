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
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int s = input[0];
            int n = input[1];
            string nb = "";
            while (n != 0)
            {
                nb += n % s;
                n /= s;
            } nb = string.Join("", nb.Reverse());
            Console.WriteLine(nb);


            }
    }
}
