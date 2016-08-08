using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class SortedPupils : IEnumerable<Pupil>
    {
        private Pupil[] pupils;
        private string option;

        public SortedPupils(Pupil[] pupils, string option)
        {
            this.pupils = pupils;
            this.option = option;
        }

        private void SortThePupils()
        {
            for (int i = pupils.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (option.CompareTo("Alphabetically") == 0)
                    {
                        if (pupils[j].CompareByName(pupils[j + 1]) == 1)
                            Swap(ref pupils[j], ref pupils[j + 1]);
                    }
                    else
                    {
                        if (option.CompareTo("ByGrade") == 0)
                            if (pupils[j].CalculateFinalGrade() < pupils[j + 1].CalculateFinalGrade())
                                Swap(ref pupils[j], ref pupils[j + 1]);
                    }
                }
            }
        }

        private void Swap(ref Pupil firstPupil, ref Pupil secondPupil)
        {
            Pupil highValue = firstPupil;
            firstPupil = secondPupil;
            secondPupil = highValue;
        }

        public IEnumerator<Pupil> GetEnumerator()
        {
                SortThePupils();
            foreach (var p in pupils)
                yield return p;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
