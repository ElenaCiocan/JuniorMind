using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void TestForTheFirstCategory()
        {
            Assert.AreEqual(0.0000000715, CalculateChances(6));
        }

        [TestMethod]
        public void TestForTheSecondCategory()
        {
            Assert.AreEqual(0.0000005244, CalculateChances(5));
        }

        [TestMethod]
        public void TestForTheThirdCategory()
        {
            Assert.AreEqual(0.0000047197, CalculateChances(4));
        }

        public double CalculateChances(int myNumbers)
        {
            double chances=1, total = 49;
            while(myNumbers>0)
            {
                chances *= (myNumbers / total);
                myNumbers--;
                total--;
            }
            return Math.Round(chances, 10);
        }
    }
}
