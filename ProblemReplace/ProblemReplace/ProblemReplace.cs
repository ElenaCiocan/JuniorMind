﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemReplace
{
    [TestClass]
    public class ProblemReplace
    {
        [TestMethod]
        public void TestForReplacingACharacter()
        {
            Assert.AreEqual("okaokcdokc", ReplaceACharacter("babcdbc", 'b', "ok"));
        }

        string ReplaceACharacter(string initialString, char characterToReplace, string stringForReplacing)
        {
            if (initialString.Length == 1)
            {
                if (initialString[0] == characterToReplace)
                    return stringForReplacing;
                else
                    return initialString[0].ToString();
            }
            else
            if (initialString[0] == characterToReplace)
                return stringForReplacing + ReplaceACharacter(initialString.Substring(1, initialString.Length - 1), characterToReplace, stringForReplacing);

            return initialString[0] + ReplaceACharacter(initialString.Substring(1, initialString.Length - 1), characterToReplace, stringForReplacing);
        }
              
        }
    }

