using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchaeologicalSite
{
    [TestClass]
    public class ArchaeologicalSite
    {
        [TestMethod]
        public void TestForSmallValues()
        {
            Assert.AreEqual(6, CalculateTheAreaOfTheSit(0, 0, 3, 0, 0, 4)); 
        }

        [TestMethod]
        public void TestForDecimalValues()
        {
            Assert.AreEqual(27.2949242226, CalculateTheAreaOfTheSit(0,0,6.721800,0,0,8.121314));
        }
        double CalculateTheAreaOfTheSit(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            double determinant = (xA * yB * 1) + (xB * yC * 1) + (yA * xC * 1) - (yB * xC * 1) - (yC * xA * 1) - (xB * yA * 1);
            return Math.Abs(determinant) / 2;
        }

    } 
}
