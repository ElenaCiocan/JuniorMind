using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void FindThePrefixOfTwoStrings()
        {
            Assert.AreEqual("aaa", FindThePrefix("aaab", "aaaabbaa"));
        }

        [TestMethod]
        public void TestForTwoStringsWithoutCommonPrefix()
        {
            Assert.AreEqual(null, FindThePrefix("AAab", "aaaabbaa"));
        }

        string FindThePrefix(string firstString, string secondsString)
        {
            string prefix = null;
            int noOfEqualLetters = 0;
            CompareStrings(firstString, secondsString, ref noOfEqualLetters);
            for (int i = 0; i < noOfEqualLetters; i++)
                prefix += firstString[i];
            return prefix;
        }

        private static int CompareStrings(string firstString, string secondsString, ref int noOfEqualLetters)
        {
             for (int i = 0; i < Math.Min(firstString.Length, secondsString.Length); i++)
                if (firstString[i] == secondsString[i])
                    noOfEqualLetters++;
                else
                    break;
            return noOfEqualLetters;
        }
    }
}
