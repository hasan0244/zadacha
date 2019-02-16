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
            int rows = int.Parse(Console.ReadLine()); 
            int cols = int.Parse(Console.ReadLine()); 
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                double avg = 0;
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 8}", matrix[row, col]);
                    avg += matrix[row, col];
                }
                avg = avg / cols;
                Console.WriteLine("{0, 8}", avg);
            }


        }
    }
}
