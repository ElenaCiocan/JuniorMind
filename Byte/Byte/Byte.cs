using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Byte
{
    [TestClass]
    public class Byte
    {
        private object CollectionsAssert;

        [TestMethod]
        public void TestForConversionToBinary()
        {
            CollectionAssert.AreEqual(new byte[]{1,0}, ConvertToAGivenBase(2));
            CollectionAssert.AreEqual(new byte[] { 1,0 ,0, 0, 0 }, ConvertToAGivenBase(16));
            CollectionAssert.AreEqual(new byte[] { 0 }, ConvertToAGivenBase(0));
        }

        [TestMethod]
        public void TestForConversionToHexadecimal()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 4, 2, 10, 2 }, ConvertToAGivenBase(82594,16));
            CollectionAssert.AreEqual(new byte[] { 2 }, ConvertToAGivenBase(2, 16));

        }

        [TestMethod]
        public void TestForLogicFunctionNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, Not(ConvertToAGivenBase(2)));
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, Not(ConvertToAGivenBase(12)));

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
            CollectionAssert.AreEqual(ConvertToAGivenBase(2&3), And(ConvertToAGivenBase(2),ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(6 & 3), And(ConvertToAGivenBase(6), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 & 12), And(ConvertToAGivenBase(2), ConvertToAGivenBase(12)));

        }

        [TestMethod]
        public void TestForLogicFunctionOr()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 | 3), Or(ConvertToAGivenBase(2), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(6 | 3), Or(ConvertToAGivenBase(6), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 | 12), Or(ConvertToAGivenBase(2), ConvertToAGivenBase(12)));

        }

        [TestMethod]
        public void TestForLogicFunctionXor()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 ^ 3), Xor(ConvertToAGivenBase(2), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(6 ^ 3), Xor(ConvertToAGivenBase(6), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 ^ 12),Xor(ConvertToAGivenBase(2), ConvertToAGivenBase(12)));
        }

        [TestMethod]
        public void TestForRightHandShift()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(10>>2), RightHandShift(ConvertToAGivenBase(10), 2));
        }

        [TestMethod]
        public void TestForLeftHandShift()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(10 << 2), LeftHandShift(ConvertToAGivenBase(10), 2));
        }

        [TestMethod]
        public void TestForLessThan()
        {
            Assert.AreEqual(2 < 8, LessThan(ConvertToAGivenBase(2), ConvertToAGivenBase(8)));
            Assert.AreEqual(25 < 8, LessThan(ConvertToAGivenBase(25), ConvertToAGivenBase(8)));
            Assert.AreEqual(8 < 2, LessThan(ConvertToAGivenBase(8), ConvertToAGivenBase(2)));
        }

        [TestMethod]
        public void TestforSum()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(8 + 8), Sum(ConvertToAGivenBase(8), ConvertToAGivenBase(8)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(526 + 8,16), Sum(ConvertToAGivenBase(526,16), ConvertToAGivenBase(8,16), 16));
        }

        [TestMethod]
        public void TestForSubstraction()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(10 -2), Substraction(ConvertToAGivenBase(10), ConvertToAGivenBase(2)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 - 2), Substraction(ConvertToAGivenBase(2), ConvertToAGivenBase(2)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(526-8,16), Substraction(ConvertToAGivenBase(526,16), ConvertToAGivenBase(8,16),16));


        }

        [TestMethod]
        public void TestForMultiplication()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(2 * 3), Multiplication(ConvertToAGivenBase(2), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(10 * 10), Multiplication(ConvertToAGivenBase(10), ConvertToAGivenBase(10)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(100 * 100,16), Multiplication(ConvertToAGivenBase(100,16), ConvertToAGivenBase(100,16),16));
        }

        [TestMethod]
        public void TestForDivision()
        {   
            CollectionAssert.AreEqual(ConvertToAGivenBase(12 / 3), Division(ConvertToAGivenBase(12), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(3 / 3), Division(ConvertToAGivenBase(3), ConvertToAGivenBase(3)));
            CollectionAssert.AreEqual(ConvertToAGivenBase(320 / 16, 16), Division(ConvertToAGivenBase(320, 16), ConvertToAGivenBase(16, 16), 16));
        }

        [TestMethod]
        public void TestForGreaterThan()
        {
            Assert.AreEqual(2 > 8, GreaterThan(ConvertToAGivenBase(2), ConvertToAGivenBase(8)));
            Assert.AreEqual(25 > 8, GreaterThan(ConvertToAGivenBase(25), ConvertToAGivenBase(8)));
            Assert.AreEqual(8 > 8, GreaterThan(ConvertToAGivenBase(8), ConvertToAGivenBase(8)));
        }

        [TestMethod]
        public void TestForEqual()
        {
            Assert.AreEqual(8 == 8, Equal(ConvertToAGivenBase(8), ConvertToAGivenBase(8)));
            Assert.AreEqual(25 == 24, Equal(ConvertToAGivenBase(25), ConvertToAGivenBase(24)));
        }

        [TestMethod]
        public void TestForNotEqual()
        {
            Assert.AreEqual(25 != 8, NotEqual(ConvertToAGivenBase(25), ConvertToAGivenBase(8)));
            Assert.AreEqual(24 != 24, NotEqual(ConvertToAGivenBase(24), ConvertToAGivenBase(24)));
        }

        [TestMethod]
        public void TestForFactorial()
        {
            CollectionAssert.AreEqual(ConvertToAGivenBase(49), Division(Factorial(ConvertToAGivenBase(49)), Factorial(ConvertToAGivenBase(48))));
        }

        byte[] ConvertToAGivenBase(int number, int conversionBase = 2)
        {
            byte[] binaryNumber = new byte[0];
            int i = 0;
            if (number == 0)
                return new byte[] { 0 };
            while (number>0)
            {
                Array.Resize(ref binaryNumber, i+1);
                binaryNumber[i++] = (byte)(number % conversionBase);
                number /= conversionBase;
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

        bool GreaterThan(byte[] firstNumber, byte[] secondNumber)
        {
            bool result = false;
            for (int i = Math.Max(firstNumber.Length, secondNumber.Length) - 1; i >= 0; i--)
                if (GetElement(firstNumber, i) != GetElement(secondNumber, i))
                {
                    result = GetElement(firstNumber, i) > GetElement(secondNumber, i);
                    break;
                }
            return result;
        }

        bool Equal( byte[] firstNumber, byte[] secondNumber)
        {
            if (!LessThan(firstNumber, secondNumber)  && !GreaterThan(firstNumber, secondNumber)) 
                return true;
            else
                return false;
        }

        bool NotEqual(byte[] firstNumber, byte[] secondNumber)
        {
            return !Equal(firstNumber, secondNumber);
        }

        byte[] Sum(byte[] firstNumber, byte[] secondNumber, int conversionBase = 2)
        {
            int carry = 0,sum;
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                sum = GetElement(firstNumber, i) + GetElement(secondNumber, i) + carry ;
                result[i] = (byte)(sum%conversionBase);
                carry = sum / conversionBase;
            }
            if (carry == 1)
            {
                Array.Resize(ref result, result.Length + 1);
                int i = result.Length - 1;
                result[i] = (byte)carry;
            }
            Array.Reverse(result);
            return result;
        }

        byte[] Substraction(byte[] firstNumber, byte[] secondNumber, int conversionBase = 2)
        {
            int carry = 0, diff;
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                diff = conversionBase + GetElement(firstNumber, i) - GetElement(secondNumber, i) - carry;
                result[i] = (byte)(diff % conversionBase);
                carry = diff < conversionBase ? 1 : 0; 
            }
            int zeroes = CountZeroes(result);
            Array.Resize(ref result, result.Length - zeroes);
            Array.Reverse(result);
            return result;
        }

        byte[] Multiplication(byte[] firstNumber, byte[] secondNumber, int conversionBase = 2)
        {
            byte[] result = new byte[] { 0 };
            for (byte[] i = { 0 }; LessThan(i, secondNumber); i = Sum(i, ConvertToAGivenBase(1), conversionBase))
                result = Sum(result, firstNumber, conversionBase);
            return result;
        }

        byte[] Division(byte[] firstNumber, byte[] secondNumber, int conversionBase = 2)
        {
            byte[] result = new byte[] { 0 };
            while(LessThan(ConvertToAGivenBase(0),firstNumber))
            {
                firstNumber = Substraction(firstNumber, secondNumber, conversionBase);
                result = Sum(result, ConvertToAGivenBase(1),conversionBase);
            }
            return result;
        }

        byte[] Factorial(byte[] number)
        {
            byte[] result = new byte[] { 1 };
            for (byte[] i = { 2 }; LessThan(i, number); i = Sum(i, ConvertToAGivenBase(1)))
                result = Multiplication(result, i);
            return Multiplication(result,number);
        }

    }
}
