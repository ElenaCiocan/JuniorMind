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

        int CalculateTheSquaresOnAChessboard(int lenght)
        {
            return lenght * lenght + 1;
        }
    }
}
