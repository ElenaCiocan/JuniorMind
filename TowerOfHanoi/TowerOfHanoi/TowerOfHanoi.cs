using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowerOfHanoi
{
    [TestClass]
    public class TowerOfHanoi
    {
        [TestMethod]
        public void TestForMovingThreeDisks()
        {
            int[] source = { 3, 2, 1 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];

            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, MovingDisksUsingTowerOfHanoi(3, source, destination, auxiliar));
        }

        int[] MovingDisksUsingTowerOfHanoi(int noOfDisks, int[] sourcePeg, int[] destinationPeg, int[] auxiliarPeg)
        {
            if (noOfDisks == 1)
            {
                return MovingDisks(noOfDisks, sourcePeg, destinationPeg);
            }

            MovingDisksUsingTowerOfHanoi(noOfDisks - 1, sourcePeg, auxiliarPeg, destinationPeg);
            MovingDisks(noOfDisks, sourcePeg, destinationPeg);
            MovingDisksUsingTowerOfHanoi(noOfDisks - 1, auxiliarPeg, destinationPeg, sourcePeg);
            return destinationPeg;
        }

        private static int[] MovingDisks(int noOfDisks, int[] source, int[] destination)
        {
            destination[noOfDisks - 1] = source[noOfDisks - 1];
            Array.Resize(ref source, source.Length - 1);
            return source;
        }
    }
}
