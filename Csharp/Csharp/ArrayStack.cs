using System;

namespace Csharp
{
    public class ArrayStack<T> : IMyList<T>
    {
        private Array<T> _a;

        public ArrayStack(int size) {
            _a = new Array<T>(size);
        }

        public void Add(T d, int i)
        {
            throw new NotImplementedException();
        }

        public T Get(int i)
        {
            if (i >= _a.Length || i < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _a[i];
        }

        public T Remove(int i)
        {
            if (i >= _a.Length)
            {
                throw new IndexOutOfRangeException();
            }
            throw new NotImplementedException();
        }

        public T Set(T d, int i)
        {
            if (i >= _a.Length)
            {
                throw new IndexOutOfRangeException();
            }
            // validation
            T y = _a[i];
            _a[i] = d;
            return y;
        }
    }
}
