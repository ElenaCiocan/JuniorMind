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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0 }, ConvertToBinary(12));
            CollectionAssert.AreEqual(new byte[] { 0 }, ConvertToBinary(0));
        }

        [TestMethod]
        public void TestForLogicFunctionNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, Not(ConvertToBinary(2)));
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, Not(ConvertToBinary(12)));

        }

        [TestMethod]
        public void TestForGetElement()
        {
            Assert.AreEqual(0, GetElement(new byte[] { 1, 2, 3 }, 3));
            Assert.AreEqual(1, GetElement(new byte[] { 1, 2, 3 }, 2));

        }

        [TestMethod]
        public void TestForLogicFunctionAnd()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2&3), And(ConvertToBinary(2),ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(6 & 3), And(ConvertToBinary(6), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(2 & 12), And(ConvertToBinary(2), ConvertToBinary(12)));

        }
       
        byte[] ConvertToBinary ( int number )
        {
            byte[] binaryNumber = new byte[0];
            int i = 0;
            if(number==0)
            {
                Array.Resize(ref binaryNumber, 1);
                binaryNumber[0] = 0;
            }
            while (number>0)
            {
                Array.Resize(ref binaryNumber, i+1);
                binaryNumber[i++] = (byte)(number % 2);
                number /= 2;
            }
            Array.Reverse(binaryNumber);
            return binaryNumber;
        }

        byte[] Not ( byte[] number)
        {
            for (int i = 0; i < number.Length; i++)
                number[i] = (number[i] == 0) ? (byte)1 : (byte)0;
            return number;
        }

        byte[] And ( byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
                result[i] = (byte) (GetElement(firstNumber, i) * GetElement(secondNumber, i));
            int zeroes = CountZeroes(result);
           // Array.Reverse(result);
            Array.Resize(ref result, result.Length - zeroes);
            Array.Reverse(result);
            return result;
        }

        byte GetElement( byte[] number, int position)
        {
            return (byte)((position > number.Length - 1) ? 0 : number[number.Length-1-position]);
        }

        int CountZeroes( byte[] number)
        {
            int noOfZeroes= 0,i=number.Length-1;
            bool ok = true; 
            while (i > 0 && ok==true)
            {
                if (number[i] == 0)
                    noOfZeroes++;
                else
                if (number[i] != 0)
                    ok=false;
                i--;
            }
            return noOfZeroes;
        }
    }
}
