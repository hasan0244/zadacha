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
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "stop") break;
                string emails = Console.ReadLine();
                string names = (string.Join(" ", commands));
                if (emails.Contains("us") || emails.Contains("uk") && commands[0] != "stop")
                    Console.WriteLine("");
                else
                    Console.WriteLine("{0} -> {1}", names, emails);
            }


        }
    }
}
