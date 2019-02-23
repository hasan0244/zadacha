using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string last = "", result = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                var c = (int)line[i];
                if (c >= 48 && c <= 57)
                {
                    if (last != "") result += last;
                    else result += line[i].ToString();
                }
                else
                {
                    last = line[i].ToString();
                    result += line[i].ToString();
                }
            }
            Console.WriteLine(string.Join("",result.Reverse()));

        }
    }
}
