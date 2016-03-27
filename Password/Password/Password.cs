using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void TestForSmallLetters()
        {
            var password= GeneratePassword(6,2);
            Assert.AreEqual(4, CountCharacters(password,'a','z'));
        }

        [TestMethod]
        public void TestForCapitalLetters()
        {
            var password = GeneratePassword(6, 2);
            Assert.AreEqual(2, CountCharacters(password,'A','Z'));
        }

        string GeneratePassword(int length, int noOfCapitalLetters = 0)
        {
            string password = GenerateLettersAndNumbers(length - noOfCapitalLetters, 'a', 'z' + 1) + GenerateLettersAndNumbers(noOfCapitalLetters, 'A', 'Z' + 1);
            return password;
        }
        string GenerateLettersAndNumbers(int number, int start, int end)
        {
            string result = null;
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                char character = (char)random.Next(start,end);
                result += character.ToString();
            }
            return result;
        }

        int CountCharacters(string password, char first, char last)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= first && password[i] <= last)
                    count++;
            }
            return count;
        }
    }
}
