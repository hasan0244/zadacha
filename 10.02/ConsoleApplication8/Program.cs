using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (int a in nums)
                if (Math.Sqrt(a) * Math.Sqrt(a) == a) Console.WriteLine(a);
        }
    }
}
