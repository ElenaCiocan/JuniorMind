using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void TestForConversionIntoOneLetter()
        {
            Assert.AreEqual("C", ConvertFromDecimalToExcelValues(3));
        }

        [TestMethod]
        public void TestForConversionIntoLetters()
        {
            Assert.AreEqual("AB", ConvertFromDecimalToExcelValues(28));
        }

        public string ConvertFromDecimalToExcelValues( int number )
        {
            String result = String.Empty;
            while (number != 0)
            {
                number--;
                result = GetChar(number % 26) + result ;
                number /= 26;
            }
            return result;
        }

        private static string GetChar(int number)
        {
            Char convert = (Char)('A' + (number));
            return convert.ToString();
        }
    }
}
