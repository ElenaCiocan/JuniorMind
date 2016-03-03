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
            CollectionAssert.AreEqual(new byte[] { 1,0 ,0, 0, 0 }, ConvertToBinary(16));
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

        [TestMethod]
        public void TestForLogicFunctionOr()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2 | 3), Or(ConvertToBinary(2), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(6 | 3), Or(ConvertToBinary(6), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(2 | 12), Or(ConvertToBinary(2), ConvertToBinary(12)));

        }

        [TestMethod]
        public void TestForLogicFunctionXor()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2 ^ 3), Xor(ConvertToBinary(2), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(6 ^ 3), Xor(ConvertToBinary(6), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(2 ^ 12),Xor(ConvertToBinary(2), ConvertToBinary(12)));
        }

        [TestMethod]
        public void TestForRightHandShift()
        {
            CollectionAssert.AreEqual(ConvertToBinary(10>>2), RightHandShift(ConvertToBinary(10), 2));
        }

        [TestMethod]
        public void TestForLeftHandShift()
        {
            CollectionAssert.AreEqual(ConvertToBinary(10 << 2), LeftHandShift(ConvertToBinary(10), 2));
        }

        [TestMethod]
        public void TestForLessThan()
        {
            Assert.AreEqual(2 < 8, LessThan(ConvertToBinary(2), ConvertToBinary(8)));
            Assert.AreEqual(25 < 8, LessThan(ConvertToBinary(25), ConvertToBinary(8)));
            Assert.AreEqual(8 < 2, LessThan(ConvertToBinary(8), ConvertToBinary(2)));
        }

        [TestMethod]
        public void TestforSum()
        {
            CollectionAssert.AreEqual(ConvertToBinary(8 + 8), Sum(ConvertToBinary(8), ConvertToBinary(8)));
            CollectionAssert.AreEqual(ConvertToBinary(2 + 8), Sum(ConvertToBinary(2), ConvertToBinary(8)));
        }

        [TestMethod]
        public void TestForSubstraction()
        {
            CollectionAssert.AreEqual(ConvertToBinary(10 -2), Substraction(ConvertToBinary(10), ConvertToBinary(2)));
            CollectionAssert.AreEqual(ConvertToBinary(2 - 2), Substraction(ConvertToBinary(2), ConvertToBinary(2)));

        }

        [TestMethod]
        public void TestForMultiplication()
        {
            CollectionAssert.AreEqual(ConvertToBinary(2 * 3), Multiplication(ConvertToBinary(2), ConvertToBinary(3)));
            CollectionAssert.AreEqual(ConvertToBinary(10 * 10), Multiplication(ConvertToBinary(10), ConvertToBinary(10)));

        }

        byte[] ConvertToBinary ( int number )
        {
            byte[] binaryNumber = new byte[0];
            int i = 0;
            if (number == 0)
                return new byte[] { 0 };
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
            return LogicOperations(firstNumber, secondNumber, "And");
        }

        byte[] Or(byte[] firstNumber, byte[] secondNumber)
        {
            return LogicOperations(firstNumber, secondNumber, "Or");
        }

        byte[] Xor(byte[] firstNumber, byte[] secondNumber)
        {
            return LogicOperations(firstNumber, secondNumber, "Xor");
        }

        private byte[] LogicOperations(byte[] firstNumber, byte[] secondNumber, string operation)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
               result[i]= ExecuteLogicOperations(GetElement(firstNumber, i), GetElement(secondNumber, i), operation);
            int zeroes = CountZeroes(result);
            Array.Resize(ref result, result.Length - zeroes);
            Array.Reverse(result);
            return result;
        }

        private byte ExecuteLogicOperations(byte first, byte second, string operation)
        {
            switch (operation)
            {
                case "And":
                    return LogicAnd(first, second);

                case "Or":
                    return LogicOr(first, second);
            }
            return LogicXor(first, second);
        }

        byte LogicAnd(byte first , byte second)
        {
            return (byte)(first * second);
        }

        byte LogicOr(byte first, byte second)
        {
            return (first == 1 || second == 1) ? (byte)1 : (byte)0;
        }

        byte LogicXor(byte first, byte second)
        {
            return first != second ? (byte)1 : (byte)0;
        }

        byte GetElement( byte[] number, int position)
        {
            return (byte)((position > number.Length - 1) ? 0 : number[number.Length-1-position]);
        }

        int CountZeroes( byte[] number)
        {
            int noOfZeroes = 0;
            int i = number.Length - 1;
            while (i > 0)
            {
                if (number[i] != 0)
                    return noOfZeroes;
                noOfZeroes++;
                i--;
            }
            return noOfZeroes;
        }

        byte[] RightHandShift(byte[] number, int positions)
        {
            Array.Resize(ref number, number.Length-positions);
            return number;
        }

        byte[] LeftHandShift(byte[] number, int positions)
        {
            Array.Resize(ref number, number.Length + positions);
            return number;
        }

        bool LessThan(byte[] firstNumber, byte[] secondNumber)
        {
            bool result = false;
            for (int i = Math.Max(firstNumber.Length, secondNumber.Length) - 1; i >= 0; i--)
                if (GetElement(firstNumber, i) != GetElement(secondNumber, i))
                {
                    result = GetElement(firstNumber, i) < GetElement(secondNumber, i);
                    break;
                }
            return result;
        }
            
        byte[] Sum(byte[] firstNumber, byte[] secondNumber)
        {
            int carry = 0,sum;
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                sum = GetElement(firstNumber, i) + GetElement(secondNumber, i) + carry ;
                result[i] = (byte)(sum%2);
                carry = sum / 2;
            }
            if (carry == 1)
            {
                Array.Resize(ref result, result.Length + 1);
                int i = result.Length - 1;
                result[i] = 1;
            }
            Array.Reverse(result);
            return result;
        }

        byte[] Substraction( byte[] firstNumber, byte[] secondNumber)
        {
            int carry = 0, diff;
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                diff = 2 + GetElement(firstNumber, i) - GetElement(secondNumber, i) - carry;
                result[i] = (byte)(diff % 2);
                carry = diff < 2 ? 1 : 0; 
            }
            int zeroes = CountZeroes(result);
            Array.Resize(ref result, result.Length - zeroes);
            Array.Reverse(result);
            return result;
        }

        byte[] Multiplication(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] result = new byte[] { 0 };
            for (byte[] i = { 0 }; LessThan(i, secondNumber); i=Sum(i, ConvertToBinary(1)))
                result = Sum(result, firstNumber);
            return result;
        }
                
    }
}
