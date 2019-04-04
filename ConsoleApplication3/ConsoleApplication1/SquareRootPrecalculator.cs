using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SquareRootPrecalculator
    {
        private static int n = 100;
        private static double[] a;
        static SquareRootPrecalculator()
        {
            a = new double[n + 1];
            for (int i = 1; i <= n; i++)
                a[i] = Math.Sqrt(i);
        }
        public static double GetSqrt(int value)
        { return a[value]; }
    }
}
