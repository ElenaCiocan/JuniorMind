using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    [TestClass]
    public class SortedPupilsTest
    {
        [TestMethod]
        public void TestForSortedPupils()
        {
            var iulian = new Pupil("Iulian Popescu",new[] { new SchoolMatter(new int[] { 7, 9, 6, 8 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 9 }, "Matematica") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 7, 8 }, "Matematica") });
            var adrian = new Pupil("Adrian Ghisoiu", new[] { new SchoolMatter(new int[] { 9, 9, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 8 }, "Matematica") });
            var pupils = new Pupil[] { iulian, maria, adrian }; 
            var sortedPupils = new Pupil[] { adrian, iulian, maria };
            var list = new SortedPupils(pupils);

            CollectionAssert.AreEqual(sortedPupils, list.SortAlphabetically(pupils,0,pupils.Length-1));

        }

       [TestMethod]
        public void TestForSortByFinalGrade()
        {
            var iulian = new Pupil("Iulian Popescu", new[] { new SchoolMatter(new int[] { 10, 8 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 9 }, "Matematica") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 7, 8 }, "Matematica") });
            var adrian = new Pupil("Adrian Ghisoiu", new[] { new SchoolMatter(new int[] { 9, 9, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 8 }, "Matematica") });
            var pupils = new Pupil[] { iulian, maria, adrian };
            var sortedPupils = new Pupil[] { iulian, adrian, maria };
            var list = new SortedPupils(pupils);

            CollectionAssert.AreEqual(sortedPupils, list.SortByFinalGrade(pupils, 0, pupils.Length - 1));


        }

    }
}
