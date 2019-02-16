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
            int row = int.Parse(Console.ReadLine()); 
            int col = int.Parse(Console.ReadLine()); 
            int[,] a = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[] mini = new int[col];
            for (int j = 0; j < col; j++)
            {
                int m = a[0, j];
                for (int i = 1; i < row; i++)
                    if (m > a[i, j]) m = a[i, j];
                mini[j] = m;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                { Console.Write(a[i, j] + " "); }
                Console.WriteLine();
            }
            for (int i = 0; i < col; i++)
                Console.Write(mini);
            Console.WriteLine();
            
            

        }
    }
}
