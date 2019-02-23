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
            string[] s = Console.ReadLine().Split(' ');
            string s1 = s[0];
            string s2 = s[1];
            int MinLength = 1;
            int sum = 0;
            if (s1.Length > s2.Length)
            {
                MinLength = s2.Length;
                for (int i = MinLength; i < s1.Length; i++)
                    sum += (int)s1[i];
            }
            else
            {
                MinLength = s1.Length;
                for (int i = MinLength; i < s2.Length; i++)
                    sum += (int)s2[i];
            }
            for (int i = 0; i < MinLength; i++)
                sum += (int)s1[i] * (int)s2[i];
            Console.WriteLine(sum);

       
        }
    }
}
