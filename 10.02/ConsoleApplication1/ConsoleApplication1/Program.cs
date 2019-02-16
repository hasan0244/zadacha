using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static int odd(int n)
        {
            int s = 0;
            while (n != 0)
            {
                if (n % 10 % 2 != 0)
                    s += n % 10;n/=10 ;
            }
            return s;
        }
    static int even(int n)
    {
        int s1 = 0;
        while (n != 0)
        {
            if (n % 10 % 2 == 0)
                s1 += n % 10; n /= 10;
        }
        return s1;
    }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int p = odd(n) * even(n);
            Console.WriteLine(p);

        }
       
        



    }
}
