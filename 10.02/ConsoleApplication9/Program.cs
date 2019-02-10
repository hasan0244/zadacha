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
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
            counts[num]++;
            for (int i = 0; i < counts.Length; i++)
            {
            if (counts[i] > 0)
            Console.WriteLine("{0} -> {1}", i, counts[i]);
            }
        }
    }
}
