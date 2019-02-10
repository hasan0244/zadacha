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
            List<string> l = Console.ReadLine().Split('|').ToList();
           List <string> v=new List<string>();
            for(int i=l.Count-1;i>=0;i--)
            {
                string k=l[i];
                v.Add(k);
            }
            Console.WriteLine(String.Join(" ",v));
            
            
        }
    }
}
