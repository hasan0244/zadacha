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
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int pos = start;
            int minus = 1;
            string line = Console.ReadLine();
            do
            {
                var parts=line.Split(' ');
                string command=parts[0];
                int steps=int.Parse(parts[1]);
                switch(command)
                {
                    case "left"
                        {
                            while(steps>0)
                            {pos--;
                                if(pos<0)
                                {pos=num.Length-1;
                                    minus++;
                                }{num[pos]-=minus;
                                    steps--;}
                                break;


        }
    }
}
