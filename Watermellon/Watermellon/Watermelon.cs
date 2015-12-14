using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class Watermelon
    {
        [TestMethod]
        public void EvenNumberOfKilograms()
        {
            Assert.AreEqual("DA", VerifyParity(4));
        }

        string VerifyParity(int numberOfKilograms)
        {
            if (numberOfKilograms % 2 == 0)
                return "DA";
          return Convert.ToString(numberOfKilograms);
       
        }
    }
}
