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

        [Fact]
        public void TestForRemove()
        {
            var list = new LinkedList<int> { 1, 2, 3, 4, 5 };
            list.Remove(3);
            Assert.Equal(new[] { 1, 2, 4, 5 }, list);
            Assert.Equal(4, list.Count());
        }

        [Fact]
        public void TestForContains()
        {
            var list = new LinkedList<int> { 1, 2, 3, 4, 5 };
            Assert.True(list.Contains(3));
        }

        [Fact]
        public void TestForCopyTO()
        {
            var list = new LinkedList<int> { 1, 2 };
            var numbers = new int[] { 1, 2, 3, 4 };
            list.CopyTo(numbers, 2);
            Assert.Equal(new[] { 1, 2, 1, 2 }, numbers);
        }
    }
}
