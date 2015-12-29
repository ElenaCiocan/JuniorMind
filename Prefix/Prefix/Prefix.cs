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
            Assert.AreEqual("", FindThePrefix("AAab", "aaaabbaa"));
        }

        string FindThePrefix(string firstString, string secondsString)
        {
            string prefix = string.Empty;
            for (int i = 0; i < Math.Min(firstString.Length, secondsString.Length); i++)
                if (firstString[i] == secondsString[i])
                    prefix += firstString[i];
                else
                    break;
            if (prefix != null)
                return prefix;
            else
                return "No common prefix!";
        }
    }
}
