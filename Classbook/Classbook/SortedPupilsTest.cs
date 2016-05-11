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
            var iulian = new Pupil("Iulian Popescu");
            var maria = new Pupil("Maria Apetrii");
            var adrian = new Pupil("Adrian Ghisoui");
            var nico = new Pupil("Nicoleta Raiu");
            var elena = new Pupil("Elena Ciocan");
            var pupils = new Pupil[]{ iulian, maria, adrian, nico, elena };
            var sortedPupils = new Pupil[] { adrian, elena, iulian, maria, nico };
            var list = new SortedPupils(pupils);

            CollectionAssert.AreEqual(sortedPupils, list.SortAlphabetically(pupils,0,pupils.Length-1));

        }

    }
}
