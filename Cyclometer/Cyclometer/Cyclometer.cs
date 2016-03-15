using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        [TestMethod]
        public void TestForNoOfTotalRotations()
        {
            var cyclists = new Cyclist[] { new Cyclist(7, new int[]{ 2, 3, 4, 2, 1, 6, 5}, 12), new Cyclist(5, new int[] { 2, 3, 4, 2, 5 }, 12), new Cyclist(6, new int[] { 2, 3, 4, 2, 6, 5 }, 11), new Cyclist(7, new int[] { 2, 3, 4, 2, 1, 6, 5 }, 13) };
            Assert.AreEqual(84, CalculateNoOfRotations(cyclists));
        }

        struct Cyclist
        {
           public int noSeconds;
           public int[] noRotations;
           public double diameter;

           public Cyclist(int seconds, int[] rotations, double diameter)
            {
                noSeconds = seconds;
                noRotations = rotations;
                this.diameter = diameter;
            }
        }

        int CalculateNoOfRotations(Cyclist[] cyclists)
        {
            int noOfTotalRotations = 0;
            for (int i = 0; i < cyclists.Length; i++)
                for (int j = 0; j < cyclists[i].noSeconds; j++)
                    noOfTotalRotations += cyclists[i].noRotations[j];
            return noOfTotalRotations;
        }
    }
}
