using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverse
{
    [TestClass]
    public class Reverse
    {
        [TestMethod]
        public void TestForReversingAWord()
        {
            Assert.AreEqual("cba", ReverseAWord("abc"));
        }

        string ReverseAWord(string word)
        {
            if (word.Length == 1)
                return word;
            return word[word.Length - 1] + ReverseAWord(word.Substring(0, word.Length - 1));
        }
    }
}
