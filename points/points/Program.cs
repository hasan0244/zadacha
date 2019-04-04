using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point { x = 3, y = 4 };
            Console.WriteLine("{0},{1}",A.x,A.y);
        }
    }
}
