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
            // validation
            return a[i];
        }

        public void Remove(int i)
        {
            throw new NotImplementedException();
        }

        public T Set(T d, int i)
        {
            // validation
            T y = a[i];
            a[i] = d;
            return y;
        }
    }
}
