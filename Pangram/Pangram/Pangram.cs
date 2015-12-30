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
        
        String ConvertUpperCaseLettersToLowerCase(string sentence)
        {
            System.Text.StringBuilder givenSentence = new System.Text.StringBuilder(sentence);
            for (int i = 0; i < givenSentence.Length; i++)
                if (System.Char.IsUpper(givenSentence[i]) == true)
                    givenSentence[i] = System.Char.ToLower(givenSentence[i]);
            return givenSentence.ToString();            
        }
    }
}
