using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double V = a * b * c;
            double S1 = 2 * a * c + 2 * b * c;
            double S = S1 + 2 * a * b;
            {
                Type boxType = typeof(Box);
                System.Reflection.FieldInfo[] fields = boxType.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                Console.WriteLine(fields.Count());
            }
            
            Console.WriteLine(V);
            Console.WriteLine(S1);
            Console.WriteLine(S);
        }
    }
}
