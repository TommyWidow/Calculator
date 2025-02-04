using System;

namespace MathTools
{
    class MathOperation
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Multi(double a, double b)
        {
            return a * b;
        }

        public static double Devide(double a, double b)
        {
            return a / b;
        }

        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        public static (double, double) Abs(double a, double b)
        {
            return (a < 0 ? -a : a, b < 0 ? -b : b);
        }

    }
}



