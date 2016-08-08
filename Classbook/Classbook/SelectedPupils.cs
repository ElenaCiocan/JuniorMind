using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class SelectedPupils : IEnumerable<Pupil>
    {
        private Pupil[] pupils;
        private double grade;

        public SelectedPupils(Pupil[] pupils, double grade)
        {
            this.pupils = pupils;
            this.grade = grade;
        }

        public IEnumerator<Pupil> GetEnumerator()
        {
            foreach (var p in pupils)
            {
                if (p.CalculateFinalGrade() == grade)
                    yield return p;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
