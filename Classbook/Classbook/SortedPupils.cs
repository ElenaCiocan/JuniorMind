using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class SortedPupils
    {
        private Pupil[] pupils;

        public SortedPupils(Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public Pupil[] SortAlphabetically(Pupil[] pupils, int start, int end)
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
                    SortAlphabetically(pupils, start, j);
                if (i < end)
                    SortAlphabetically(pupils, i, end);
            }

            return pupils;

        }
    }
}
