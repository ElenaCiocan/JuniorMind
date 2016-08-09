using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        T[] numbers = new T[0] ;
        int count = 0;
        
        public T this[int index]
        {
            get
            {
                return numbers[index];
            }

            set
            {
                numbers[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[count] = item;
            count++;
        }

        public void Clear()
        {
            Array.Resize(ref numbers, 0);
            count = 0;  
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
                if (numbers[i].Equals(item))
                    return true;
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int index = arrayIndex;
            for (int i = 0; i < count; i++)
                array[index++] = numbers[i];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var no in numbers)
                yield return no;
        }

        public int IndexOf(T item)
        {
            int i;
            for ( i = 0; i < count; i++)
                if (numbers[i].Equals(item))
                    break;
             return i;
        }

        public void Insert(int index, T item)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            for (int i = count; i > index; i--)
                numbers[i] = numbers[i - 1];
            numbers[index] = item;
        }

        public bool Remove(T item)
        {
            int index=IndexOf(item);
            if (Contains(item))
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count - 1; i++)
                numbers[i] = numbers[i + 1];
            Array.Resize(ref numbers, numbers.Length-1);          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
