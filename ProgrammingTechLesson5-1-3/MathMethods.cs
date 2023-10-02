using System;

namespace ProgrammingTechLesson5_1_3
{
    public static class MathMethods
    {
        public static double Fact(int n)
        {
            double factorial;

            if (n >= 0)
            {
                factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
            }
            else
            {
                factorial = 0;
            }

            return factorial;
        }

        public static double Reciprocal(double num)
        {
            double inv = 1 / num;
            if (num * inv < 1)
            {
                inv = Math.Abs(num) / inv;
            }

            return inv;
        }

        public static double FracPart(double num)
        {
            return num - Math.Truncate(num);
        }

        public static bool IsEven(double num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsOdd(double num)
        {
            if (num % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public static double Crt(double num)
        {
            double root;
            if (num > 0)
            {
                root = Math.Pow(num, 1.0 / 3.0);
            }
            else
            {
                root = 0.0;
            }

            return root;
        }

        public static double DegToRad(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double RadToDeg(double rad)
        {
            return rad * 180 / Math.PI;
        }

        public static bool BinaryDigit(int number)
        {
            if (number <= 0)
            {
                return false;
            }
            else if (number == 1)
            {
                return true;
            }
            else
            {
                return (number & (number - 1)) == 0 && BinaryDigit(number >> 1);
            }
        }
    }
}