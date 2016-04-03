using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void TestforFindingAFibonacciNumber()
        {
            Assert.AreEqual(2, CalculateFibonacciNumber(3));
        }

        int CalculateFibonacciNumber(int number)
        {
            if (number < 2)
                return number;
            return CalculateFibonacciNumber(number - 1) + CalculateFibonacciNumber(number - 2);
        }
    }
}
