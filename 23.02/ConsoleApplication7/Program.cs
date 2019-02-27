using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "jdfjkjsd";
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine( sb);

        }
    }
}
