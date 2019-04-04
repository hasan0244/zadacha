using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestscore = 0;
            string winner = "";
            for(; ; )
            {string str=Console.ReadLine();
                int score=0;
                int y=str.Length-1;
                int a=0;
                if(str=="END OF GAME")break;
                else
                {
                    for(int i=0;i<str.Length;i++)
                    {a=a+(int)str[i];}
                }
                if (str[0]>='A' &&str[0]<='Z')
                {a=a+15;}
                if (str[y] == 't')
                { a = a + 20; }
                    if(str.Length>=10)
                    {a=a+30;}
                    score=a;
                    if(bestscore<score)
                    {bestscore=score;
                        winner=str;}}
                Console.WriteLine("Winner is word: {0}",winner);
                Console.WriteLine("Points: {0}",bestscore);

        }
    }
}
