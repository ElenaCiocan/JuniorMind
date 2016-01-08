using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void ShouldCalculateTheFactorial()
        {
            Assert.AreEqual(6, CalculateFactorial(3));
        }

        public int CalculateFactorial(int number)
        {
            int factorial=1;
            for (int i = 1; i <= number; i++)
                factorial *= i;
            return factorial;
        }
    }
}
