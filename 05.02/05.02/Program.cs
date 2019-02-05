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
            int[] sum = new int[n];
            int s=0;
            for (int i = 0; i < n; i++)
            { 
                sum[i] = int.Parse(Console.ReadLine());
                 s += sum[i];
                 
            }
            Console.WriteLine(s);

        }
    }
}
