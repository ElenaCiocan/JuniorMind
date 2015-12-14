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
            Assert.AreEqual("DA", VerifyCondition(4));
        }

        [TestMethod]
        public void OddNumberOfKilograms()
        {
            Assert.AreEqual("Nu", VerifyCondition(5));
        }

        [TestMethod]
        public void OddNumberThatDoesNotMeetOurCondition()
        {
            Assert.AreEqual("Nu", VerifyCondition(2));
        }

        string VerifyCondition(int numberOfKilograms)
        {
            return VerifyParity(numberOfKilograms) ? "DA" : "Nu";
        }

        bool VerifyParity( int number)
        {
            if (number % 2 == 0 && number != 2)
                return true;
            else
                return false;
        }
    }
}
