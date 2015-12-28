using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
    [TestClass]
    public class Debt
    {
        [TestMethod]
        public void TestForLessThanTenDays()
        {
            Assert.AreEqual(104, CalculateTheDebt(2, 100));
        }

        float CalculateTheDebt(int days, float rent)
        {
            float percentage =(float) 2 / 100;
            return rent + ( percentage * rent * days);
        }
    }
}
