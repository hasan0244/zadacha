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
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sortedNums = nums.OrderBy(x => x);
            Console.WriteLine(string.Join(" ",sortedNums));

        }
    }
}
