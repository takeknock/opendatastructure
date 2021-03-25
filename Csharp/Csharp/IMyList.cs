using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    interface IMyList<T>
    {
        T Get(int i);
        T Set(T d, int i);
        void Add(T d);
        void Remove(int i);

    }
}
