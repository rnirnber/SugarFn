using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<T, T3> Coalesce<T, T2, T3> (this Func<T, T2> self, Func<T2, T3> fn)
        {
            return new Func<T, T3>((T a) => fn(self(a)));
        }
        public static Func<T, T2, T4> Coalesce<T, T2, T3, T4>(this Func<T, T2, T3> self, Func<T3, T4> fn)
        {
            return new Func<T, T2, T4>((T a, T2 b) => fn(self(a, b)));
        }
        public static Func<T, T2, T3, T5> Coalesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4> self, Func<T4, T5> fn)
        {
            return new Func<T, T2, T3, T5>((T a, T2 b, T3 c) => fn(self(a, b, c)));
        }
        public static Func<T, T2, T3, T4, T6> Coalesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5> self, Func<T5, T6> fn)
        {
            return new Func<T, T2, T3, T4, T6>((T a, T2 b, T3 c, T4 d) => fn(self(a, b, c, d)));
        }
        public static Func<T, T2, T3, T4, T5, T7> Coalesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6> self, Func<T6, T7> fn)
        {
            return new Func<T, T2, T3, T4, T5, T7>((T a, T2 b, T3 c, T4 d, T5 e) => fn(self(a, b, c, d, e)));
        }
        public static Func<T, T2, T3, T4, T5, T6, T8> Coalesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7> self, Func<T7, T8> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, T8>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => fn(self(a, b, c, d, e, f)));
        }
    }
}
