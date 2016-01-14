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
            Assert.AreEqual(0.0000000715, CalculateChances(6,6,49));
        }

        [TestMethod]
        public void TestForTheSecondCategory()
        {
            Assert.AreEqual(0.0000184499, CalculateChances(5,6,49));
        }

        [TestMethod]
        public void TestForTheThirdCategory()
        {
            Assert.AreEqual(0.0009686197, CalculateChances(4,6,49));
        }

        [TestMethod]
        public void TestForTheFirstCategoryAtFiveFromForty()
        {
            Assert.AreEqual(0.0000015197, CalculateChances(5,5, 40));
        }

        public double CalculateChances(double matchingNumbers, double ticketNumbers, double totalNumbers)
        {
            double result = 1;
            result = CalculateFraction(ticketNumbers, matchingNumbers) * CalculateFraction((totalNumbers - ticketNumbers), (ticketNumbers - matchingNumbers));
            result /= CalculateFraction(totalNumbers, ticketNumbers);
            return Math.Round(result, 10);
        }
        public double CalculateFraction(double numerator, double denominator)
        {
            double result=1;
            while(Math.Min(numerator,denominator)>0)
            {
                result *= (numerator/ denominator);
                numerator--;
                denominator--;
            }
            return result;
        }
    }
}
