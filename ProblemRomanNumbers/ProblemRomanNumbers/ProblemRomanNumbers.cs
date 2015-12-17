using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemRomanNumbers
{
    [TestClass]
    public class ProblemRomanNumbers
    {
        [TestMethod]
        public void ConversionOfOne()
        {
            Assert.AreEqual("I", ConvertToRomanNumbers(1));
        }

        string ConvertToRomanNumbers(int number)
        {
                return "I";
        }
    }
}
