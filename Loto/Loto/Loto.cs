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
            Assert.AreEqual(0.0000000715, CalculateChances(6,49));
        }

        [TestMethod]
        public void TestForTheSecondCategory()
        {
            Assert.AreEqual(0.0000005244, CalculateChances(5,49));
        }

        [TestMethod]
        public void TestForTheThirdCategory()
        {
            Assert.AreEqual(0.0000047197, CalculateChances(4,49));
        }

        [TestMethod]
        public void TestForTheFirstCategoryAtFiveFromForty()
        {
            Assert.AreEqual(0.0000015197, CalculateChances(5, 40));
        }

        public double CalculateChances(int myNumbers, double total)
        {
            double chances=1;
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
