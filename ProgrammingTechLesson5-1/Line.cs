namespace ProgrammingTechLesson5_1
{
    public class Line
    {
        private Point _pointStart;
        private Point _pointEnd;

        public Point GetStartPoint() => _pointStart;
        public Point GetEndPoint() => _pointEnd;
        public double Length() => _pointStart.Distance(_pointEnd);


        public Line(Point pointStart, Point pointEnd)
        {
            this._pointStart = pointStart;
            this._pointEnd = pointEnd;
        }

        /// <summary>
        /// Проверяет принадлежность точки отрезку
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool isBelongAtLine(Point point)
        {
            if (_pointStart.Distance(point) + _pointEnd.Distance(point) - Length() == 0)
            {
                return true;
            }

            return false;
        }
    }
}