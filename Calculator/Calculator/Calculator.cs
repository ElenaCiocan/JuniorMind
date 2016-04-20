using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void TestForSplit()
        {
            CollectionAssert.AreEqual(new string[] { "a", "b", "c" }, SplitExpresion("a b c"));
        }

        [TestMethod]
        public void TestForSimpleMultiplication()
        {
            int index = 0;
            Assert.AreEqual(24, CalculateOperations("* * 2 3 4", ref index));
        }

        [TestMethod]
        public void TestForMultipleOperations()
        {
            int index = 0;
            Assert.AreEqual(1549.41, CalculateOperations("+ / * + 56 45 46 3 - 1 0.25", ref index), 1e-2);
        }

        double CalculateOperations(string input, ref int index)
        {
            double number;
            string[] splitedInput = SplitExpresion(input);
            string element = splitedInput[index++];
            if (double.TryParse(element, out number))
                return number;
            else
            {
                if (element.Equals("*"))
                    return CalculateOperations(input, ref index) * CalculateOperations(input, ref index);
                if (element.Equals("/"))
                    return CalculateOperations(input, ref index) / CalculateOperations(input, ref index);
                if (element.Equals("+"))
                    return CalculateOperations(input, ref index) + CalculateOperations(input, ref index);
                if (element.Equals("-"))
                    return CalculateOperations(input, ref index) - CalculateOperations(input, ref index);
            }
            return 0;
        }
        private static string[] SplitExpresion(string input)
        {
            return input.Split(' ');
        }
    }
}

