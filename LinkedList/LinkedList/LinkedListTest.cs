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

        [Fact]
        public void TestForRemoveFirst()
        {
            var list = new LinkedList<int> { 1, 2, 3 };
            list.RemoveFirst();
            Assert.Equal(new[] { 2, 3 }, list);
            Assert.Equal(2, list.Count());
        }

        [Fact]
        public void TestForRemoveLast()
        {
            var list = new LinkedList<int> { 1, 2, 3 };
            list.RemoveLast();
            Assert.Equal(new[] { 1, 2 }, list);
            Assert.Equal(2, list.Count());
        }

    }
}
