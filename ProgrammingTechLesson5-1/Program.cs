using System;

namespace ProgrammingTechLesson5_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Поинты");
            Point somePoint = new Point(3, 3);
            Point somePoint2 = new Point(4, 4);
            Point somePoint3 = new Point(5, 5);
            Point somePoint4 = new Point(6, 6);
            GC.Collect();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());


            Console.WriteLine("Квадрат");
            Point squarePoint = new Point(8, 5);
            Square square = new Square(squarePoint, 5);
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            square.DisplayVertices();
            GC.Collect();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            GC.Collect();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());

            
            Console.WriteLine("Линия");
            Point linePoint1 = new Point(10, 10);
            Point linePoint2 = new Point(12, 12);
            Line line = new Line(linePoint1, linePoint2);
            line.isBelongAtLine(linePoint1);
            line.DisplayVertices();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            GC.Collect();

            Console.Read();
            Console.WriteLine("Количество Поинтов = " + Point.GetCounter());
            
        }
    }
}