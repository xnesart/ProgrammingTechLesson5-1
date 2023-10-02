namespace ProgrammingTechLesson5_1
{
    public class Square
    {
        private Point _startPointSquare;
        private Line _sideLength;
      

        public Square(Point leftTopAngle, int side)
        {
            _startPointSquare = leftTopAngle;
            _sideLength = new Line(leftTopAngle, new Point(leftTopAngle.GetX() + side, leftTopAngle.GetY()));
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

       
    }
}