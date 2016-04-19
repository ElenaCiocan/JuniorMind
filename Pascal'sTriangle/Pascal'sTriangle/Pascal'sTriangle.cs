using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pascal_sTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForThirdRow()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, CalculateRowOfPascalTriangle(3));
        }

        int[] CalculateRowOfPascalTriangle( int rowNumber)
        {
            int[] row = new int[rowNumber];
           // int[] previousRow = new int[rowNumber];
            row[0] = 1;
            row[rowNumber - 1] = 1;
            if (rowNumber == 1)
                return new int[] { 1 };
            int []previousRow = CalculateRowOfPascalTriangle(rowNumber - 1);
            CalculatePascalRow(rowNumber, row, previousRow);
            return row;
        }

        private static void CalculatePascalRow(int rowNumber, int[] row, int[] previousRow)
        {
            for (int j = 1; j < rowNumber - 1; j++)
                row[j] = previousRow[j - 1] + previousRow[j];
        }
    }
}
