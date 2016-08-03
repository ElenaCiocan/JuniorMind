using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Classbook
{    
    public class SortedPupilsTest
    {
        [Fact]
        public void TestForSortedPupils()
        {
            var iulian = new Pupil("Iulian Popescu",new[] { new SchoolMatter(new int[] { 7, 9, 6, 8 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 9 }, "Matematica") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 7, 8 }, "Matematica") });
            var adrian = new Pupil("Adrian Ghisoiu", new[] { new SchoolMatter(new int[] { 9, 9, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 8 }, "Matematica") });
         
           Assert.Equal(new[] { adrian, iulian, maria }, new SortedPupils(new[] { iulian, maria, adrian }, "Alphabetically"));

        }

      [Fact]
        public void TestForSortByFinalGrade()
        {
            var iulian = new Pupil("Iulian Popescu", new[] { new SchoolMatter(new int[] { 10, 8 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 9 }, "Matematica") });
            var maria = new Pupil("Maria Apetrii", new[] { new SchoolMatter(new int[] { 7, 2, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 7, 8 }, "Matematica") });
            var adrian = new Pupil("Adrian Ghisoiu", new[] { new SchoolMatter(new int[] { 9, 9, 6, 7 }, "Fizica"), new SchoolMatter(new int[] { 10, 9, 8 }, "Matematica") });

            Assert.Equal(new[] { iulian, adrian, maria }, new SortedPupils(new[] { iulian, maria, adrian }, "ByGrade"));
        }
    }
}
