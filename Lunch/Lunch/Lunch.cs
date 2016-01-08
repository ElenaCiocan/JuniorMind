using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestForTheFirstMeeting()
        {
            Assert.AreEqual(12, CalculateDayOfMeeting(4,6));
        }

        public int CalculateDayOfMeeting(int firstPersonDay, int secondPersonDay)
        {
            int product, greatestCommonDivisor;
            product = firstPersonDay * secondPersonDay;
            greatestCommonDivisor = FindGreatestCommonDivisor(firstPersonDay, secondPersonDay);
            return product / greatestCommonDivisor;
        }

        public int FindGreatestCommonDivisor( int firstNumber, int secondNumber)
        {
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            return firstNumber;
        }
    }
}
