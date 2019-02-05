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
            int s = 0;
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            int[] arr = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
                s += arr[i];
            }
            Console.WriteLine(s);
            
        }
    }
}
