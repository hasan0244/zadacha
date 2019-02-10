using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int index=0;index<nums.Count;index++)
            {
                if(nums[index]%2==0)
                 Console.WriteLine(nums[index]);}

        }
    }
}
