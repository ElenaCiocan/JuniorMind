using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
    [TestClass]
    public class Debt
    {
        [TestMethod]
        public void TestForShortPeriods()
        {
            Assert.AreEqual(104, CalculateTheDebt(2, 100));
        }

        [TestMethod]
        public void TestForMediumPeriods()
        {
            Assert.AreEqual(160, CalculateTheDebt(12, 100));
        }

        [TestMethod]
        public void TestForLongPeriods()
        {
            Assert.AreEqual(450, CalculateTheDebt(35, 100));
        }

        float CalculateTheDebt(int days, float rent)
        {
            float shortPeriodPercentage =(float) 2 / 100;
            float mediumPeriodPercentage = (float) 5 / 100;
            float longPeriodPercentage = (float) 10 / 100;
            if (days>31)
                return rent + ( longPeriodPercentage * rent * days);
            else
                if(days>11)
                return rent + (mediumPeriodPercentage * rent * days);
            else
                return rent + (shortPeriodPercentage * rent * days);


        }
    }
}
