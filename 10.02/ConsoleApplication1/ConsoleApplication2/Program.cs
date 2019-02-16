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
            int[,] intMatrix = 
           {
             {2, 8, 3, 5},
             {7, 9, 0, 3}
           };

            for (int row = 0; row < intMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLength(1); col++)
                {
                    Console.Write(intMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
