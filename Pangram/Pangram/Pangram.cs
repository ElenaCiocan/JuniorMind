using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void ModifyAllTheLettersInLowerCaseLetters()
        {
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", ConvertUpperCaseLettersToLowerCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }

        [TestMethod]
        public void TestIfTheSentenceIsAPangramOrNot()
        {
            Assert.AreEqual("Yes", FindIfASentenceIsAPangramOrNot("The quick brown fox jumps over the lazy dog."));
        }


        String ConvertUpperCaseLettersToLowerCase(string sentence)
        {
            System.Text.StringBuilder givenSentence = new System.Text.StringBuilder(sentence);
            for (int i = 0; i < givenSentence.Length; i++)
                if (System.Char.IsUpper(givenSentence[i]) == true)
                    givenSentence[i] = System.Char.ToLower(givenSentence[i]);
            string finalSentence = givenSentence.ToString();
            return finalSentence;       
        }
        
        String FindIfASentenceIsAPangramOrNot(string initialSentence)
        {
            int[] noOfApparitionsOfEachLetter = new int[27];
            string finalSentence = ConvertUpperCaseLettersToLowerCase(initialSentence);
            CalculateNumberOfApparitionsOfEachLetter(finalSentence, out noOfApparitionsOfEachLetter);
            for (int i = 0; i < 26; i++)
                if (noOfApparitionsOfEachLetter[i] > 0)
                    continue;
                else
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
