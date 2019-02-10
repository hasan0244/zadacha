using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = nums[nums.Count - 1];
            while (nums.Contains(n))
            {
                nums.Remove(n);
            }
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
