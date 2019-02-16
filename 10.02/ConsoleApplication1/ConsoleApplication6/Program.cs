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
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                var line=Console.ReadLine().Split(' ');
                int c=0;
                foreach(var item in line)
                    matrix[r,c++]=int.Parse(item);
            }
                double d1=0,d2=0;
                for(int k=0;k<rows;k++) d1+=matrix[k,k];
                for (int k = 0; k < rows; k++) d1 += matrix[k, rows - k - 1];
                double s1 = 0, s2 = 0;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; cols++)
                    {
                        if (col > row) s1 += matrix[row, col];
                        if (cols < row) s2 += matrix[row, cols];
                    }
                }
                if (d1 == d2 && s1 % 2 == 0 && s2 % 2 != 0) Console.WriteLine("Yes");

                else
                {
                    Console.WriteLine("No");
                    return;
                }
                double sd = 0;
                for (int k = 0; k < rows; k++)
                    if (matrix[k, k] % 2 == 0) sd += matrix[k, k];
                double sr = 0;
                for (int k = 0; k < cols; k++)
                {
                    if (matrix[0, k] % 2 == 0) sr += matrix[0, k];
                    if (matrix[rows - 1, k] % 2 == 0) sr += matrix[rows - 1, k];
                }
                double sc = 0;
                for (int k = 0; k < rows; k++)
                {
                    if (matrix[k, 0] % 2 != 0) sc += matrix[k, 0];
                    if (matrix[cols - 1, k] % 2 != 0) sc += matrix[k, cols - 1];
                }
                double avr = (s2 + sd + sr + sc) / 4.0;
                Console.WriteLine("The amount of money won is: {0:f2}", avr);
                
         }
    }
}
