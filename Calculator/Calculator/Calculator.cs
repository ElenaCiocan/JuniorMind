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
            CollectionAssert.AreEqual(new string[] { "a", "b", "c" }, CalculateOperations("a b c"));
        }

        string[] CalculateOperations( string input)
        {
            string[] splitedInput = input.Split(' ');
            return splitedInput; 
        }
    }
}
