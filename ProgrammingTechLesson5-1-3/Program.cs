using System;

namespace ProgrammingTechLesson5_1_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Расчёт факториала");
            Console.WriteLine(MathMethods.Fact(5));
            Console.WriteLine("Вычисление обратного числового значения аргумента ");
            Console.WriteLine(MathMethods.Reciprocal(5));
            Console.WriteLine("Возврат дробной части числового аргумента ");
            Console.WriteLine(MathMethods.FracPart(5.33));
            Console.WriteLine("Возврат флага четности аргумента ");
            Console.WriteLine(MathMethods.IsEven(5.33));
            Console.WriteLine("Возврат флага нечетности аргумента ");
            Console.WriteLine(MathMethods.IsOdd(5.33));
            Console.WriteLine("Вычисление кубического корня аргумента ");
            Console.WriteLine(MathMethods.Crt(10));
            Console.WriteLine("Вычисление радиан по аргументу в градусах");
            Console.WriteLine(MathMethods.DegToRad(10));
            Console.WriteLine("Вычисление градусов по аргументу в радианах");
            Console.WriteLine(MathMethods.RadToDeg(10));
            Console.WriteLine("Проверка числа на принадлежность ряду чисел-степеней двойки");
            Console.WriteLine(MathMethods.BinaryDigit(16));
        }
    }
}