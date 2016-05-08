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
        public Pupil( string name)
        {
            this.name = name;
        }

        public int CompareByName(Pupil pupil)
        {
            return String.Compare(name, pupil.name);
        }
    }
}
