using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook
{
    [TestClass]
    public class PupilTest
    {
        [TestMethod]
        public void TestForCamparisonByName()
        {

            var iulian = new Pupil("Iulian Popescu", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 1, 2, 3 }, "Romana") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 1, 2, 3 }, "Romana") });
            Assert.AreEqual(-1, iulian.CompareByName(maria));
        }

        [TestMethod]
        public void TestForFinalGrade()
        {
            var elena = new Pupil("Elena Ciocan", new[] { new SchoolMatter(new int[] { 10, 9 }, "Matematica"), new SchoolMatter(new int[] { 8, 8 }, "Romana") });
            Assert.AreEqual(8.75, elena.CalculateFinalGrade(elena));
        }
    }
}
