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

        [TestMethod]
        public void ConversionOfNine()
        {
            Assert.AreEqual("IX", ConvertToRomanNumbers(9));
        }

        string ConvertToRomanNumbers(int number)
        {
            string[] romanunits = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return romanunits[number-1];
        }
    }
}
