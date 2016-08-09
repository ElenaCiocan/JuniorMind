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
    }
}
