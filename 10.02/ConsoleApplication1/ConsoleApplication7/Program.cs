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
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            int bestsum = int.MinValue;
            int bestrow=0;
            int bestcol = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestsum)
                    {
                        bestsum = sum;
                        bestrow = row;
                        bestcol = col;
                    }
                }
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine("{0} {1}", matrix[bestrow, bestcol],matrix[bestrow,bestcol+1]);
            Console.WriteLine("{0} {1}", matrix[bestrow + 1, bestcol], matrix[bestrow + 1, bestcol + 1]);
            Console.WriteLine("The maximal sum is: {0}", bestsum);

        }
    }
}
