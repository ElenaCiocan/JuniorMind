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
        private string matter;

        public SchoolMatter(int[] grades, string matter)
        {
            this.grades = grades;
            this.matter = matter;
        }

        public double CalculateArithmeticalMean( )
        {
            double mean = 0, arithmeticalMean=0;
            for (int i = 0; i < grades.Length; i++)
                mean += grades[i];
            arithmeticalMean = mean / grades.Length;
            return arithmeticalMean;
        }
    }
}
