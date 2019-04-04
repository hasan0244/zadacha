using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Geometry
    {
        public static double SquarePerimeter(double side)
        { return side * 4; }
        public static double SquareArea(double side)
        { return side * side; }
        public static double RectanglePerimeter(double a, double b)
        { return 2 * (b + a); }
        public static double RectangleArea(double a, double b)
        { return b * a; }
        public static double CircleArea(double r)
        { return 2*r * 3.14; }
        
    }
}
