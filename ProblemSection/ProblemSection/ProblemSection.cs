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
            if (direction.Equals(Direction.Right))
                startingPoint.y -= distance;
            return startingPoint;
        }
    }
}
