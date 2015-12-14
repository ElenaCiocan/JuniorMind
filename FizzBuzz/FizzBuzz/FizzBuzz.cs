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
            Assert.AreEqual("Fizz", CalculateMultiple(6));

        }

        [TestMethod]
        public void VerifyMultipleOfFive()
        {
            Assert.AreEqual("Buzz", CalculateMultiple(25));

        }

        [TestMethod]
        public void VerifyMultipleOfThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", CalculateMultiple(30));

        }

        string CalculateMultiple(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return Convert.ToString(0);
        }
    }
}
