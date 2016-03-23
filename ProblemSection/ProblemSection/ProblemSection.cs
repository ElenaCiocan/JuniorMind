using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSection
{
    [TestClass]
    public class ProblemSection
    {
        [TestMethod]
        public void TestForNextPoint()
        {
            var point = new Point(2,6);
            var initPoint = new Point(2, 3);
            Assert.AreEqual(point, CalculateNextPoint(initPoint, Direction.Up, 3));
        }

        [TestMethod]
        public void TestForIntersection()
        {
            var point = new Point(5,3);
            var initPoint = new Point(2, 3);
            var directions = new Direction[] {Direction.Right,Direction.Right,Direction.Up,Direction.Left,Direction.Down };
            Assert.AreEqual(true, CalculateIntersectionPoint(initPoint, directions, 3,out point));
        }

        struct Point
        {
           public double x;
           public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        enum Direction
        {
            Right=1,
            Left,
            Up,
            Down
        }

        Point CalculateNextPoint( Point startingPoint, Direction direction, int distance)
        {
            if (direction.Equals(Direction.Right))
                startingPoint.x += distance;
            if (direction.Equals(Direction.Left))
                startingPoint.x -= distance;
            if (direction.Equals(Direction.Up))
                startingPoint.y += distance;
            if (direction.Equals(Direction.Down))
                startingPoint.y -= distance;
            return startingPoint;
        }

        bool CalculateIntersectionPoint(Point startingPoint, Direction[] directions, int distance, out Point intersectionPoint)
        {
            intersectionPoint = new Point(0, 0);
            Point point=startingPoint;
            Point[] allPoints = new Point[directions.Length+1];
            allPoints[0] = startingPoint;
            for (int i = 0; i < directions.Length; i++)
            {
                point = CalculateNextPoint(startingPoint, directions[i], distance);
                for (int j = 0; j < allPoints.Length; j++)
                    if (point.Equals(allPoints[j]))
                    {
                        intersectionPoint = point;
                        return true;
                    }
                    else
                        allPoints[i + 1] = point;
            }
            return false; 
        }
    }
}
