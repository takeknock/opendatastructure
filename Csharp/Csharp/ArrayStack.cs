using System;

namespace Csharp
{
    public class ArrayStack<T> : IMyList<T>
    {
        private T[] a;

        public ArrayStack(int size) {
            a = new T[size];
        }

        public void Add(T d)
        {
            throw new NotImplementedException();
        }

        public T Get(int i)
        {
            if (i >= a.Length)
            {
                throw new IndexOutOfRangeException();
            }
            // validation
            return a[i];
        }

        public T Remove(int i)
        {
            if (i >= a.Length)
            {
                throw new IndexOutOfRangeException();
            }
            throw new NotImplementedException();
        }

        public T Set(T d, int i)
        {
            if (i >= a.Length)
            {
                throw new IndexOutOfRangeException();
            }
            // validation
            T y = a[i];
            a[i] = d;
            return y;
        }
    }
}
