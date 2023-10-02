using System;

namespace ProgrammingTechLesson5_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point somePoint = new Point(3, 3);
            Point somePoint2 = new Point(3, 3);
            Point somePoint3 = new Point(3, 3);
            Point somePoint4 = new Point(3, 3);
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());

            GC.Collect();

            Console.Read();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            
        }
    }
}