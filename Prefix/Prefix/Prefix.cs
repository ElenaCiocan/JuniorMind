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

        string FindThePrefix(string firstString, string secondsString)
        {
            int noOfEqualLetters=0,i;
            string prefix=null;
            for (i = 0; i < Math.Min(firstString.Length, secondsString.Length); i++)
                if (firstString[i] == secondsString[i])
                    noOfEqualLetters++;
                else
                    break;
            for (i = 0; i < noOfEqualLetters; i++)
                prefix += firstString[i];
            return prefix;
        }
    }
}
