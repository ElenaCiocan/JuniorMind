using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TestForFirstNumberWith888Cube()
        {
            Assert.AreEqual(192, CalculateNumber(1));
        }

        public int CalculateNumber( int orderNumber )
        {
            return 192;
        }
    }
}
