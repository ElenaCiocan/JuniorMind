using System;
using Xunit;

namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact]
        public void TestForAddLast()
        {
           var list = new LinkedList<int> { 1, 2 };
            list.AddAtTheEnd(3);
            Assert.Equal(new[] { 1, 2, 3 }, list);
        }
        
        [Fact]
        public void TestForAddAtTheBegining()
        {
            var list = new LinkedList<int> { 1, 2 };
            list.AddAtTheBegining(0);
            Assert.Equal(new[] { 0, 1, 2 }, list);
        }

    }
}
