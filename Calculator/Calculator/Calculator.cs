using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
       
        [TestMethod]
        public void TestForSimpleMultiplication()
        {
            
            Assert.AreEqual(24, CalculateOperations("* * 2 3 4"));
        }

        [TestMethod]
        public void TestForMultipleOperations()
        {
            Assert.AreEqual(1549.41, CalculateOperations("+ / * + 56 45 46 3 - 1 0,25"), 1e-2);
        }

        double CalculateOperations(string input)
        {
            string[] splitedInput = input.Split(' ');
            int index = 0;
            return Calculate(splitedInput, ref index);
           
        }

        double Calculate(string[] elements, ref int index)
        {
            double number;
            string element = elements[index++];
            if (double.TryParse(element, out number))
                return number;
             return ExecuteOperations(element, Calculate(elements, ref index), Calculate(elements, ref index));
        }

        private double ExecuteOperations(string element,double first, double second)
        {
            switch (element)
            {
                case "*":
                    return first * second; 
                case "/":
                    return first / second;
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                default:
                    return 0;
            }
        }

    }
}

