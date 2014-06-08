using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<bool> NOT(this Func<bool> self)
        {
            return new Func<bool>(() => !self());
        }
        public static Func<T, bool> NOT<T> (this Func<T, bool> self)
        {
            return new Func<T, bool>((T a) => !self(a));
        }
        public static Func<T, T2, bool> NOT<T, T2> (this Func<T, T2, bool> self)
        {
            return new Func<T, T2, bool>((T a, T2 b) => !self(a, b));
        }
        public static Func<T, T2, T3, bool> NOT<T, T2, T3> (this Func<T, T2, T3, bool> self)
        {
            return new Func<T, T2, T3, bool>((T a, T2 b, T3 c) => !self(a, b, c));
        }
        public static Func<T, T2, T3, T4, bool> NOT<T, T2, T3, T4>(this Func<T, T2, T3, T4, bool> self)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => !self(a, b, c, d));
        }
        public static Func<T, T2, T3, T4, T5, bool> NOT<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5, bool> self)
        {
            return new Func<T, T2, T3, T4, T5, bool>((T a, T2 b, T3 c, T4 d, T5 e) => !self(a, b, c, d, e));
        }
        public static Func<T, T2, T3, T4, T5, T6, bool> NOT<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6, bool> self)
        {
            return new Func<T, T2, T3, T4, T5, T6, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => !self(a, b, c, d, e, f));
        }
        public static Func<T, T2, T3, T4, T5, T6, T7, bool> NOT<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7, bool> self)
        {
            return new Func<T, T2, T3, T4, T5, T6, T7, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => !self(a, b, c, d, e, f, g));
        }

    }
}
