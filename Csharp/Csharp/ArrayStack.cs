using System;

namespace Csharp
{
    public class ArrayStack<T> : IMyList<T>
    {
        private Array<T> _a;
        private int _n;

        public ArrayStack(int size) {
            _a = new Array<T>(size);
            _n = 0;
        }

        public void Add(T d, int i)
        {
            if (_n + 1 >= _a.Length)
            {
                _a.Resize();
            }
            for(int j = i; j < _n; ++j)
            {
                _a[j + 1] = _a[j];
            }
            _a[i] = d;
            _n++;
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
            _n--;
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
