using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void ShouldCalculateTheFactorial()
        {
            Assert.AreEqual(6, CalculateFactorial(3));
        }

        [TestMethod]
        public void ShouldFindOnlyUniqueCharacters()
        {
            Assert.AreEqual("abcdefzg", FindEachUniqueChar("aaabbbcccddddefzggg"));
        }


        [TestMethod]
        public void ShouldCalculateNumberOfApparitions()
        {
            Assert.AreEqual(3, CalculateNumberOfApparitions("aaabbbcccddddefzggg","a"));
        }

        public int CalculateFactorial(int number)
        {
            int factorial=1;
            for (int i = 1; i <= number; i++)
                factorial *= i;
            return factorial;
        }

        public String FindEachUniqueChar(string word)
        {
            string uniqueChar = String.Empty;
            int[] check = new int[27];
            for (int i = 0; i < word.Length; i++)
                if (check[(word[i] - 96)] == 0)
                {
                    uniqueChar += word[i];
                    check[word[i] - 96] = 1;
                }
            return uniqueChar;
        }

        public int CalculateNumberOfApparitions(string word , String character)
        {
            int index = 0;
            for(int i=0;i<word.Length;i++)
               if (word[i] == Convert.ToChar(character))
                    index++;
            return index;
            
        }
    }
}
