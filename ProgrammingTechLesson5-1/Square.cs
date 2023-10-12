using System;

namespace ProgrammingTechLesson5_1
{
    public class Square
    {
        private Point _startPointSquare;
        private Line _sideLength;
        private Point[] vertices = new Point[4];


        public Square(Point leftTopAngle, int side)
        {
            _startPointSquare = leftTopAngle;
            _sideLength = new Line(leftTopAngle, new Point(leftTopAngle.GetX() + side, leftTopAngle.GetY()));
            vertices[0] = leftTopAngle;

            // Вершина B (верхний правый угол)
            vertices[1] = new Point(leftTopAngle.GetX() + side, leftTopAngle.GetY());

            // Вершина C (нижний правый угол)
            vertices[2] = new Point(leftTopAngle.GetX() + side, leftTopAngle.GetY() - side);

            // Вершина D (нижний левый угол)
            vertices[3] = new Point(leftTopAngle.GetX(), leftTopAngle.GetY() - side);
        }
        /// <summary>
        /// вычисляет площадь квадрата
        /// </summary>
        /// <returns></returns>
        public double getSquare()
        {
            return _sideLength.Length() * _sideLength.Length();
        }
        /// <summary>
        /// вычисляет периметр квадрата
        /// </summary>
        /// <returns></returns>
        public double getPerimeter()
        {
            return 4 * _sideLength.Length();
        }
        public void DisplayVertices()
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                Console.Write($"Vertex {i + 1}: ");
                vertices[i].DisplayInfo();
            }
        }
    }
}