﻿using System;
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
                switch(operation)
                {
                    case "And":
                        result[i] = LogicAnd(GetElement(firstNumber, i), GetElement(secondNumber, i));
                        break;
                    case "Or":
                        result[i] = LogicOr(GetElement(firstNumber, i), GetElement(secondNumber, i));
                        break;
                    case "Xor":
                        result[i] = LogicXor(GetElement(firstNumber, i), GetElement(secondNumber, i));
                        break;
                }
            int zeroes = CountZeroes(result);
            Array.Resize(ref result, result.Length - zeroes);
            Array.Reverse(result);
            return result;
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
            
    }
}
