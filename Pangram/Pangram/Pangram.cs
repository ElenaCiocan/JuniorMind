using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class Pangram
    {
        
        [TestMethod]
        public void TestIfTheSentenceIsAPangram()
        {
            Assert.AreEqual("Yes", FindIfASentenceIsAPangramOrNot("The quick brown fox jumps over the lazy dog."));
        }

        [TestMethod]
        public void TestIfTheSentenceIsNotAPangram()
        {
            Assert.AreEqual("No", FindIfASentenceIsAPangramOrNot("The quick brown fox jumps over the dog."));
        }

        String FindIfASentenceIsAPangramOrNot(string initialSentence)
        {
            int[] noOfApparitionsOfEachLetter = new int[27];
            string finalSentence = initialSentence.ToLower();
            CalculateNumberOfApparitionsOfEachLetter(finalSentence, out noOfApparitionsOfEachLetter);
            for (int i = 0; i < 26; i++)
                if (noOfApparitionsOfEachLetter[i] <= 0)
                    return "No";
            return "Yes";
        }

        void CalculateNumberOfApparitionsOfEachLetter(string finalSentence,out int[] number)
        {
            number = new int[27];
            for (int i = 0; i < finalSentence.Length; i++)
                if (Char.IsLetter(finalSentence[i]))
                    number[finalSentence[i] - 97]++;
         }

    }
}
