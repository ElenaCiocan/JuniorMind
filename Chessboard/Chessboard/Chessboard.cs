using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chessboard
{
    [TestClass]
    public class Chessboard
    {
        [TestMethod]
        public void TestForATwoByTwoBoard()
        {
            Assert.AreEqual(5, CalculateTheSquaresOnAChessboard(2));
        }

        [TestMethod]
        public void TestForAEightByEightChessboard()
        {
            Assert.AreEqual(204, CalculateTheSquaresOnAChessboard(8));
        }

        int CalculateTheSquaresOnAChessboard(int lenght)
        {
            int noOfSquares = 0;
            for (int i = 1; i <= lenght; i++)
                noOfSquares += (i * i);
            return noOfSquares;
        }

    }
}
