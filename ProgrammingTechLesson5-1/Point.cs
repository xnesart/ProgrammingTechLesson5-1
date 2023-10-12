using System;

namespace ProgrammingTechLesson5_1
{
    public class Point : ICounter
    {
        private double CoordinatesX;
        private double CoordinatesY;
        private static int counter;

        public Point(double coordinatesX, double coordinatesY)
        {
            this.CoordinatesX = coordinatesX;
            this.CoordinatesY = coordinatesY;
            counter++;
        }
        
        ~Point()
        {
            counter--;
            Console.WriteLine("Деструктуризация");
        }

        public double GetX()
        {
            return this.CoordinatesX;
        }
        public double GetY()
        {
            return this.CoordinatesY;
        }

        public int Counter() => counter;
        public static double GetCounter()
        {
            return counter;
        }

        /// <summary>
        /// вычисляет расстояние от точки до начала координат
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(CoordinatesX - 0, 2) + Math.Pow(CoordinatesY - 0, 2));
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(CoordinatesX - point.CoordinatesX, 2) +
                             Math.Pow(CoordinatesY - point.CoordinatesY, 2));
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Point: ({CoordinatesX}, {CoordinatesY})");
        }
    }
}