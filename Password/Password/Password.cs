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
            var password= GeneratePassword(new Option(7,2,3,1,false,true));
            Assert.AreEqual(1, CountCharacters(password,'a','z'));
        }

        [TestMethod]
        public void TestForCapitalLetters()
        {
            var password = GeneratePassword(new Option(7, 2, 3, 1, false, true));
            Assert.AreEqual(2, CountCharacters(password,'A','Z'));
        }

        [TestMethod]
        public void TestForNumbers()
        {
            var password = GeneratePassword(new Option(7, 2, 3, 1, false, true));
            Assert.AreEqual(3, CountCharacters(password, (char)0, (char)9));
        }

        [TestMethod]
        public void TestForSymbols()
        {
            string symbols = "!#$%&()*,+-./:;<=>?@[\\]^_'`{|}~";
            var password = GeneratePassword(new Option(7, 2, 3, 1, false, true));
            Assert.AreEqual(1, CountSymbols(password,symbols));
        }

        [TestMethod]
        public void TestForEliminateCharacters()
        {
            Assert.AreEqual("aaa", GenerateLettersAndNumbers(3, 'a', 'c', "b"));
        }

        [TestMethod]
        public void TestForEliminateSymbols()
        {
            var symbols = "@#";
            Assert.AreEqual("@@", GenerateSymbols(2, symbols, "#")); 
        }

        struct Option
        {
            public int length;
            public int noOfCapitalLetters;
            public int noOfNumbers;
            public int noOfSymbols;
            public bool eliminateSimilarCharacters;
            public bool eliminateAmbiguousCharacters;

            public Option(int length,int noOfCapitalLetters, int noOfNumbers, int noOfSymbols, bool eliminateSimilarCharacters, bool eliminateAmbiguousCharacters)
            {
                this.length = length;
                this.noOfCapitalLetters = noOfCapitalLetters;
                this.noOfNumbers = noOfNumbers;
                this.noOfSymbols = noOfSymbols;
                this.eliminateSimilarCharacters = eliminateSimilarCharacters;
                this.eliminateAmbiguousCharacters = eliminateAmbiguousCharacters;
            }
        }
        string GeneratePassword(Option options)
        {
            string password = null;
            string symbols = "!#$%&()*,+-./:;<=>?@[\\]^_'`{|}~";
            string similarCharacters = string.Empty;
            string ambiguousCharacters = string.Empty;

            /*   for (int i = 0; i < options.Length; i++)
               {
                   if (options[i].optionNumber == 1)
                       password += GenerateLettersAndNumbers(options[i].length, 'a', 'z' + 1,options[i].eliminateSimilarCharacters);
                   if (options[i].optionNumber == 2)
                       password += GenerateLettersAndNumbers(options[i].length, 'A', 'Z' + 1,options[i].eliminateSimilarCharacters);
                   if (options[i].optionNumber == 3)
                       password += GenerateLettersAndNumbers(options[i].length, 0, 10, options[i].eliminateSimilarCharacters);
                   if (options[i].optionNumber == 4)
                       password += GenerateSymbols(options[i].length, symbols,options[i].eliminateAmbiguousCharacters);
               }*/
            int noOfSmallLetters = options.length - options.noOfCapitalLetters - options.noOfNumbers - options.noOfSymbols;
            if (options.eliminateSimilarCharacters)
                similarCharacters = "l1Io0O";
            password = GenerateLettersAndNumbers(noOfSmallLetters, 'a', 'z' + 1, similarCharacters)
                     + GenerateLettersAndNumbers(options.noOfCapitalLetters, 'A', 'Z' + 1, similarCharacters)
                     + GenerateLettersAndNumbers(options.noOfNumbers, 0, 10, similarCharacters);
            if (options.eliminateAmbiguousCharacters)
                ambiguousCharacters = "{}[]()/\'~,;.<>";
            password += GenerateSymbols(options.noOfSymbols, symbols, ambiguousCharacters);
            return ShufflePassword(password);
        }

        string GenerateLettersAndNumbers(int number, int start, int end, string charactersToEliminate)
        {
            Random random = new Random();
            string result = null;
            char[] eliminate = charactersToEliminate.ToCharArray(0, charactersToEliminate.Length);
           // if(eliminateCharacters)
           // {
                for (int i = 0; i < number; i++)
                {
                    char character = (char)random.Next(start, end);
                    while(Array.IndexOf(eliminate,character)>=0)
                         character = (char)random.Next(start, end);
                    result += character.ToString();
                }
           // }
           /* else
            {
                for (int i = 0; i < number; i++)
                {
                    char character = (char)random.Next(start, end);
                    result += character.ToString();
                }
            }*/
            return result;
        }

        string GenerateSymbols(int number, string symbols, string charactersToEliminate)
        {
            string result = null;
            Random random = new Random();
            char[] eliminate = charactersToEliminate.ToCharArray(0, charactersToEliminate.Length);
           // if (eliminateCharacters)
          //  {
                for (int i = 0; i < number; i++)
                {
                    int position = random.Next(0, symbols.Length);
                    while (Array.IndexOf(eliminate, symbols[position]) >= 0)
                        position = random.Next(0, symbols.Length);
                    result += symbols[position];
                }
           /* }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    int position = random.Next(0, symbols.Length);
                    result += symbols[position];
                }
            }*/
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

         string ShufflePassword(string password)
        {
            Random rand = new Random();
            char[] finalPassword = password.ToCharArray();
            int contor = finalPassword.Length;
            while (contor > 1)
            {
                contor--;
                int k = rand.Next(contor + 1);
                var value = finalPassword[k];
                finalPassword[k] = finalPassword[contor];
                finalPassword[contor] = value;
            }
            return new string(finalPassword);
        }
    }
}
