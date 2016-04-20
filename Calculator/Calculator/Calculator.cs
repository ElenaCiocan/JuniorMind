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

        double CalculateOperations(string input, ref int index)
        {
            double number;
            string[] splitedInput = SplitExpresion(input);
            string element = splitedInput[index++];
            if (double.TryParse(element, out number))
                return number;
            else
            {
                if (element == "*") ;
                return CalculateOperations(input, ref index) * CalculateOperations(input, ref index);
            }

        }

        private static string[] SplitExpresion(string input)
        {
            return input.Split(' ');
        }
    }
}
