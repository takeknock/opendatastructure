using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    static class CloneableExtension
    {
        public static T CloneEx<T>(this T src) where T : class, ICloneable
          => src.Clone() as T;
    }
}
