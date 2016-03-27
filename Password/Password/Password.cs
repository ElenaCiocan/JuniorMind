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
            var password= GeneratePassword(new Option[] { new Option(1, 4), new Option(2, 2)});
            Assert.AreEqual(4, CountCharacters(password,'a','z'));
        }

        [TestMethod]
        public void TestForCapitalLetters()
        {
            var password = GeneratePassword(new Option[] { new Option(1, 4), new Option(2, 2) });
            Assert.AreEqual(2, CountCharacters(password,'A','Z'));
        }

        [TestMethod]
        public void TestForNumbers()
        {
            var password = GeneratePassword(new Option[] { new Option(1, 4), new Option(2, 2), new Option(3,3)} );
            Assert.AreEqual(3, CountCharacters(password, (char)0, (char)9));
        }

        [TestMethod]
        public void TestForSymbols()
        {
            string symbols = "!#$%&()*,+-./:;<=>?@[\\]^_'`{|}~";
            var password = GeneratePassword(new Option[] { new Option(1, 4), new Option(2, 2), new Option(3, 3), new Option(4,5) });
            Assert.AreEqual(5, CountSymbols(password,symbols));
        }

        struct Option
        {
            public int optionNumber;
            public int length;

            public Option(int optionNumber, int length)
            {
                this.optionNumber = optionNumber;
                this.length = length;
            }
        }
        string GeneratePassword(Option[] options)
        {
            string password = null;
            string symbols = "!#$%&()*,+-./:;<=>?@[\\]^_'`{|}~";
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].optionNumber == 1)
                    password += GenerateLettersAndNumbers(options[i].length, 'a', 'z' + 1);
                if (options[i].optionNumber == 2)
                    password += GenerateLettersAndNumbers(options[i].length, 'A', 'Z' + 1);
                if (options[i].optionNumber == 3)
                    password += GenerateLettersAndNumbers(options[i].length, 0, 10);
                if (options[i].optionNumber == 4)
                    password += GenerateSymbols(options[i].length, symbols);

            }
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

        string GenerateSymbols(int number, string symbols)
        {
            string result = null;
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                int position = random.Next(0,symbols.Length);
                result += symbols[position];
            }
            return result;
        }
        int CountCharacters(string password, char first, char last)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
                if (password[i] >= first && password[i] <= last)
                    count++;
            return count;
        }

        int CountSymbols(string password, string symbols)
        {
            int count = 0;
            char[] symbol= symbols.ToCharArray(0,symbols.Length);
            for (int i = 0; i < password.Length; i++)
                if (Array.IndexOf(symbol, password[i]) >= 0)
                    count++;
            return count;
        }
    }
}
