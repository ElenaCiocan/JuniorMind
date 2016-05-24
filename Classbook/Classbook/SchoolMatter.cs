using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    class SchoolMatter
    {
        private int[] grades;

        public SchoolMatter(int[] grades)
        {
            this.grades = grades;
        }

        public double CalculateArithmeticalMean( int[] grades)
        {
            double mean = 0, arithmeticalMean=0;
            for (int i = 0; i < grades.Length; i++)
                mean += grades[i];
            arithmeticalMean = mean / grades.Length;
            return arithmeticalMean;
        }
    }
}
