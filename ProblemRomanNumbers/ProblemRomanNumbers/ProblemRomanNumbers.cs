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

        [TestMethod]
        public void ConversionOfTwentyFive()
        {
            Assert.AreEqual("XXV", ConvertToRomanNumbers(25));
        }

        [TestMethod]
        public void ConversionOfNineHundredNinetyFour()
        {
            Assert.AreEqual("CMXCIV", ConvertToRomanNumbers(994));
        }

        string ConvertToRomanNumbers(int number)
        {
            string[] romanunits = new string[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] romantens = new string[] { "","X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC",};
            string[] romanhundreds = new string[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M" };
            return romanhundreds[number/100] + romantens[number % 100 / 10] + romanunits[number % 10];
        }
    }
}
