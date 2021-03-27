using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class Array<T> : ICloneable
    {
        private T[] _a;
        public int Length { get; private set; }
        public Array(int len)
        {
            Length = len;
            _a = new T[len];
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _a[i];
            }
            set
            {
                if (i < 0 || i >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _a[i] = value;

            }
        }

        public object Clone()
        {
            Array<T> next = new Array<T>(Length);
            next._a = this._a.Clone() as T[];
            return next;
        }

        public void Resize()
        {

        }
    }
}
