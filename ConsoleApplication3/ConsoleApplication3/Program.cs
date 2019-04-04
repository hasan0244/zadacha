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
            Console.WriteLine(Geometry.SquarePerimeter(4));
            Console.WriteLine(Geometry.SquareArea(7));
            Console.WriteLine(Geometry.RectanglePerimeter(4,12));
            Console.WriteLine(Geometry.RectangleArea(4,12));
            Console.WriteLine(Geometry.CircleArea(4));
        }
    }
}
