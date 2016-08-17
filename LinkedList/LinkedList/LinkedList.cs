﻿using System;
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
