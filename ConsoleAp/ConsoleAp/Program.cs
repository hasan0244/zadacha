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
            double sum = 0;
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                string a = Console.ReadLine();
                if (a == "treadmill")
                { sum = sum + 5899; }
                if (a == "cross trainer")
                { sum = sum + 1699; }
                if (a == "exercise bike")
                { sum = sum + 1789; }
                if (a == "dumbbells")
                { sum = sum + 579; }
            }
            Console.WriteLine("{0:f2}",sum);

                            
        }
    }
}
