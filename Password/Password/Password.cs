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
            var password= GenerateLettersAndNumbers(3, 'a', 'z' + 1);
            Assert.AreEqual(3, CountSmallLetters(password));
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

        int CountSmallLetters(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                    count++;
            }
            return count;
        }
    }
}
