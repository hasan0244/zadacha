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
            
            List<int> result = new List<int>();
            int min = nums[0];
            int max = nums[0];
            for(int index=0;index<nums.Count;index++)
            {
                if (nums[index] == min || nums[index] == max)
                    result.Add(nums[index]);
                Console.WriteLine(nums[index]);
            }
        }
    }
}
