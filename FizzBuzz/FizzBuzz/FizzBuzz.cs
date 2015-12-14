using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void VerifyMultipleOfThree()
        {
            Assert.AreEqual("Fizz", CalculateMultipleOfThree(6));

        }

        string CalculateMultipleOfThree(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return Convert.ToString(number);
        }
    }
}
