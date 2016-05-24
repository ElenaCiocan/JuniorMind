using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classbook
{
    [TestClass]
    public class SchoolMatterTest
    {
        [TestMethod]
        public void TestForArithmeticalMean()
        {
            var grades = new int[]{9,8,6};
            var mathematics = new SchoolMatter(grades);
            Assert.AreEqual(7.66, mathematics.CalculateArithmeticalMean(grades), 1e-2);
        }
    }
}
