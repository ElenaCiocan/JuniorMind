using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TestForFirstNumber()
        {
            Assert.AreEqual(192, CalculateNumber(1));
        }

        [TestMethod]
        public void TestForAnyNumber()
        {
            Assert.AreEqual(1192, CalculateNumber(5));
        }

        public int CalculateNumber( int orderNumber )
        {
            int number = 192;
            for (int i = 0; i < orderNumber-1; i++)
                number += 250;
            return number;
        }
    }
}
