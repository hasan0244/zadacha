using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {            
            var emails = new Dictionary<string, string>();
            int row = 1;
            string line = Console.ReadLine();
            string name = line;
            while(line!="stop")
            {
                if (row % 2 == 0) emails[name] = line;
                else name = line;
                line = Console.ReadLine();
                row++;
            }
            foreach (var pair in emails)
            {
                if (!(pair.Value.ToLower().Contains("us") || pair.Value.ToLower().Contains("uk")))
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
