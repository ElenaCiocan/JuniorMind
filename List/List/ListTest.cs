using System;
using Xunit;

namespace List
{
    public class ListTest
    {
        [Fact]
        public void TestForAdd()
        {
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(25);

            Assert.Equal(new[] { 25 }, listOfNumbers);
        }
        
        [Fact]
        public void TestForCount()
        {
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(25);
            listOfNumbers.Add(8);

            Assert.Equal(2,listOfNumbers.Count);
        }

        [Fact]
        public void TestForClear()
        {
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(25);
            listOfNumbers.Add(8);
            listOfNumbers.Clear();
            Assert.Empty(listOfNumbers);
        }

        [Fact]
        public void TestForContains()
        {
            var listOfNumbers = new List<int>();
            listOfNumbers.Add(25);
            listOfNumbers.Add(8);

            Assert.Equal(true, listOfNumbers.Contains(25));
        }

        [Fact]
        public void TestForCopyTo()
        {
            var listOfNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var numbers = new int[]{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            listOfNumbers.CopyTo(numbers, 2);

            Assert.Equal(new int[] {10,9,1,2,3,4,5,6,7,8 }, numbers);
        }
    }
}
