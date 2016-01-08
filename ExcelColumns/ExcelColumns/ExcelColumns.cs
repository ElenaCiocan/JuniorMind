using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void TestForConversion()
        {
            Assert.AreEqual("C", ConvertFromDecimalToExcelValues(3));
        }

        public string ConvertFromDecimalToExcelValues( int number )
        {
            Char result = (Char)('A' + (number - 1));
            return result.ToString();
        }
    }
}
