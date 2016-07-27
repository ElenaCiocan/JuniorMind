using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class Pupil
    {
        private string name;
        private SchoolMatter[] schoolmatters;

        public Pupil( string name, SchoolMatter[] schoolmatters)
        {
            this.name = name;
            this.schoolmatters = schoolmatters;
        }

        public int CompareByName(Pupil pupil)
        {
            return String.Compare(name, pupil.name);
        }

         public double CalculateFinalGrade()
        {
            double grade=0;
            for (int i = 0; i< schoolmatters.Length; i++)
                grade += schoolmatters[i].CalculateArithmeticalMean();
            return grade / schoolmatters.Length;
        }

    }
}
