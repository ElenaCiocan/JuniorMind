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

        private void SortAlphabetically(int start, int end)
        {
            int i = start;
            int j = end;
            Pupil pivot = pupils[(start + end) / 2], auxiliar;

            while (i <= j)
            {
                while (pupils[i].CompareByName(pivot) == -1)
                    i++;

                while (pupils[j].CompareByName(pivot) == 1)
                    j--;

                if (i <= j)
                {
                    auxiliar = pupils[i];
                    pupils[i] = pupils[j];
                    pupils[j] = auxiliar;
                    i++;
                    j--;
                }
                if (start < j)
                    SortAlphabetically(start, j);
                if (i < end)
                    SortAlphabetically(i, end);
            }

        }

        private void SortByFinalGrade()
        {
            for (int i = pupils.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (pupils[j].CalculateFinalGrade() < pupils[j + 1].CalculateFinalGrade())
                    {
                        Pupil highValue = pupils[j];
                        pupils[j] = pupils[j + 1];
                        pupils[j + 1] = highValue;
                    }
                }
            }
        }

        public IEnumerator<Pupil> GetEnumerator()
        {
            if (option.CompareTo("Alphabetically") == 0)
                SortAlphabetically(0, pupils.Length-1);
            else
                if (option.CompareTo("ByGrade") == 0)
                SortByFinalGrade();
            foreach (var p in pupils)
                yield return p;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
