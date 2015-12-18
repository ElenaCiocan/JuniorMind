using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
    [TestClass]
    public class FarmersLand
    {
        [TestMethod]
        public void TestForSmallDimensions()
        {
            Assert.AreEqual(2, CalculateTheInitialDimensionOfTheLand(4, 12));
        }

        [TestMethod]
        public void TestForTheRequestedDimensions()
        {
            Assert.AreEqual(770, CalculateTheInitialDimensionOfTheLand(230, 770000));
        }

        [TestMethod]
        public void TestForNegativeValues()
        {
            Assert.AreEqual(0, CalculateTheInitialDimensionOfTheLand(230, -770000));
        }

        double CalculateTheInitialDimensionOfTheLand(int width, int finalArea)
        {
            double delta = width * width - (4 * 1 * (-1) * finalArea);
            if (delta > 0)
            {
                double initialLength = (-width + Math.Sqrt(delta)) / 2 * 1;
                // we use only minus because a length can not be negative
                return initialLength;
            }
            else
                return 0;
        }
    }
}
