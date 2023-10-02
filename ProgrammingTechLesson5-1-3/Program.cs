using System;

namespace ProgrammingTechLesson5_1_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MathMethods.Fact(5));
            Console.WriteLine(MathMethods.Reciprocal(5));
            Console.WriteLine(MathMethods.FracPart(5.33));
            Console.WriteLine(MathMethods.IsEven(5.33));
            Console.WriteLine(MathMethods.IsOdd(5.33));
            Console.WriteLine(MathMethods.Crt(10));
            Console.WriteLine(MathMethods.DegToRad(10));
            Console.WriteLine(MathMethods.RadToDeg(10));
            Console.WriteLine(MathMethods.BinaryDigit(16));
        }
    }
}