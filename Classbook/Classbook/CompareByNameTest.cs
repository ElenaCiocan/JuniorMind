using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class CompareByNameTest
    {
        [TestMethod]
        public void TestForCamparisonByName()
        {
            var iulian = new Pupil("Iulian Popescu");
            var maria = new Pupil("Maria Apetrii");

            Assert.AreEqual(-1, iulian.CompareByName(maria));
        }
    }
}
