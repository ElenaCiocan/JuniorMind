using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Byte
{
    [TestClass]
    public class Byte
    {
        [TestMethod]
        public void TestForConversionToBinary()
        {
            CollectionAssert.AreEqual(new byte[]{1,0}, ConvertToBinary(2));
            CollectionAssert.AreEqual(new byte[] { 1,1,0,0 }, ConvertToBinary(12));

        }

        byte[] ConvertToBinary ( int number )
        {
            byte[] binaryNumber = new byte[0];
            int i = 0;
            while(number>0)
            {
                Array.Resize(ref binaryNumber, i+1);
                binaryNumber[i++] = (byte)(number % 2);
                number /= 2;
            }
            Array.Reverse(binaryNumber);
            return binaryNumber;
        }
    }
}
