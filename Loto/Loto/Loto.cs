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
            Assert.AreEqual(0.00000007, CalculateChances(6));
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
            return Math.Round(chances, 8);
        }
    }
}
