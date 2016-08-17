using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> sentinel;
        private int noOfNodes;

        public LinkedList()
        {
            sentinel = new Node<T>(default(T));
            sentinel.Next = sentinel;
            sentinel.Previous = sentinel;
            noOfNodes = 0;
        }
        public int Count()
        {          
            return noOfNodes; 
        }

        public void Add(T value)
        {
            AddAtTheEnd(value);
        }

        public void AddAtTheEnd(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = sentinel;
            node.Previous = sentinel.Previous;
            sentinel.Previous.Next = node;
            sentinel.Previous = node;

            noOfNodes++;
        }

        public void AddAtTheBegining(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = sentinel.Next;
            node.Previous = sentinel;
            sentinel.Next = node;
            sentinel.Next.Previous = node;          

            noOfNodes++;
        }

        public void RemoveFirst()
        {
            sentinel.Next = sentinel.Next.Next;
            sentinel.Next.Previous = sentinel;
            noOfNodes--;
        }

        public void RemoveLast()
        {
            sentinel.Previous = sentinel.Previous.Previous;
            sentinel.Previous.Next = sentinel;
            noOfNodes--;
        }

        public void Remove(T item)
        {
            Node<T> current = sentinel.Next;
            while(!current.Equals(sentinel))
            {
                if(current.Data.Equals(item))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    noOfNodes--;
                }
                current = current.Next;
            }
        }

        public bool Contains(T value)
        {
            Node<T> current = sentinel.Next;
            while (!current.Equals(sentinel))
            {
                if (current.Data.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (index < 0 || index > array.Length - 1)
                throw new ArgumentOutOfRangeException();
            if (noOfNodes > (array.Length - index))
                throw new ArgumentException();
            Node<T> current = sentinel.Next;
            while (current != sentinel && index < array.Length)
            {
                array.SetValue(current.Data, index++);
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = sentinel.Next;
            while (!node.Equals(sentinel))
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
