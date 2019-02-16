using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
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
                for (int col = 0; col < cols; col++)
                { 
                   matrix[row, col] = int.Parse(Console.ReadLine());
                   
                }
                
            }
            

        }
    }
}
