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
            var iulian = new Pupil("Iulian Popescu",new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "FIZICa"), new SchoolMatter(new int[] { 1, 2, 3 }, "Bam") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "FIZICa"), new SchoolMatter(new int[] { 1, 2, 3 }, "Bam") });
            var adrian = new Pupil("Adrian Ghisoiu", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "FIZICa"), new SchoolMatter(new int[] { 1, 2, 3 }, "Bam") });
            //  var nico = new Pupil("Nicoleta Raiu");
            //  var elena = new Pupil("Elena Ciocan");
            var pupils = new Pupil[] { iulian, maria, adrian }; //nico, elena };
            var sortedPupils = new Pupil[] { adrian, iulian, maria };
            var list = new SortedPupils(pupils);

            CollectionAssert.AreEqual(sortedPupils, list.SortAlphabetically(pupils,0,pupils.Length-1));

        }  
        
    }
}
