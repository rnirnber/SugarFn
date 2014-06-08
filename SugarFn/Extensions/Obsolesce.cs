using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<T2, T3, T4, T5, T6, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6, T7, T8>((T2 a, T3 b, T4 c, T5 d, T6 e, T7 f) => self(val, a, b, c, d, e, f));
        }
        public static Func<T, T3, T4, T5, T6, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T2 val)
        {
            return new Func<T, T3, T4, T5, T6, T7, T8>((T a, T3 b, T4 c, T5 d, T6 e, T7 f) => self(a, val, b, c, d, e, f));
        }
        public static Func<T, T2, T4, T5, T6, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T3 val)
        {
            return new Func<T, T2, T4, T5, T6, T7, T8>((T a, T2 b, T4 c, T5 d, T6 e, T7 f) => self(a, b, val, c, d, e, f));
        }
        public static Func<T, T2, T3, T5, T6, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T4 val)
        {
            return new Func<T, T2, T3, T5, T6, T7, T8>((T a, T2 b, T3 c, T5 d, T6 e, T7 f) => self(a, b, c, val, d, e, f));
        }
        public static Func<T, T2, T3, T4, T6, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T5 val)
        {
            return new Func<T, T2, T3, T4, T6, T7, T8>((T a, T2 b, T3 c, T4 d, T6 e, T7 f) => self(a, b, c, d, val, e, f));
        }
        public static Func<T, T2, T3, T4, T5, T7, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T6 val)
        {
            return new Func<T, T2, T3, T4, T5, T7, T8>((T a, T2 b, T3 c, T4 d, T5 e, T7 f) => self(a, b, c, d, e, val, f));
        }
        public static Func<T, T2, T3, T4, T5, T6, T8> Obsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val)
        {
            return new Func<T, T2, T3, T4, T5, T6, T8>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(a, b, c, d, e, f, val));
        }


        public static Func<T2, T3, T4, T5, T6, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6, T7>((T2 a, T3 b, T4 c, T5 d, T6 e) => self(val, a, b, c, d, e));
        }
        public static Func<T, T3, T4, T5, T6, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T2 val)
        {
            return new Func<T, T3, T4, T5, T6, T7>((T a, T3 b, T4 c, T5 d, T6 e) => self(a, val, b, c, d, e));
        }
        public static Func<T, T2, T4, T5, T6, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T3 val)
        {
            return new Func<T, T2, T4, T5, T6, T7>((T a, T2 b, T4 c, T5 d, T6 e) => self(a, b, val, c, d, e));
        }
        public static Func<T, T2, T3, T5, T6, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T4 val)
        {
            return new Func<T, T2, T3, T5, T6, T7>((T a, T2 b, T3 c, T5 d, T6 e) => self(a, b, c, val, d, e));
        }
        public static Func<T, T2, T3, T4, T6, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T5 val)
        {
            return new Func<T, T2, T3, T4, T6, T7>((T a, T2 b, T3 c, T4 d, T6 e) => self(a, b, c, d, val, e));
        }
        public static Func<T, T2, T3, T4, T5, T7> Obsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val)
        {
            return new Func<T, T2, T3, T4, T5, T7>((T a, T2 b, T3 c, T4 d, T5 e) => self(a, b, c, d, e, val));
        }


        public static Func<T2, T3, T4, T5, T6> Obsolesce<T, T2, T3, T4, T5, T6> (this Func<T, T2, T3, T4, T5, T6> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6>((T2 a, T3 b, T4 c, T5 d) => self(val, a, b, c, d));
        }
        public static Func<T, T3, T4, T5, T6> Obsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T2 val)
        {
            return new Func<T, T3, T4, T5, T6>((T a, T3 b, T4 c, T5 d) => self(a, val, b, c, d));
        }
        public static Func<T, T2, T4, T5, T6> Obsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T3 val)
        {
            return new Func<T, T2, T4, T5, T6>((T a, T2 b, T4 c, T5 d) => self(a, b, val, c, d));
        }
        public static Func<T, T2, T3, T5, T6> Obsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T4 val)
        {
            return new Func<T, T2, T3, T5, T6>((T a, T2 b, T3 c, T5 d) => self(a, b, c, val, d));
        }
        public static Func<T, T2, T3, T4, T6> Obsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val)
        {
            return new Func<T, T2, T3, T4, T6>((T a, T2 b, T3 c, T4 d) => self(a, b, c, d, val));
        }


        public static Func<T2, T3, T4, T5> Obsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T val)
        {
            return new Func<T2, T3, T4, T5>((T2 a, T3 b, T4 c) => self(val, a, b, c));
        }
        public static Func<T, T3, T4, T5> Obsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T2 val)
        {
            return new Func<T, T3, T4, T5>((T a, T3 b, T4 c) => self(a, val, b, c));
        }
        public static Func<T, T2, T4, T5> Obsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T3 val)
        {
            return new Func<T, T2, T4, T5>((T a, T2 b, T4 c) => self(a, b, val, c));
        }
        public static Func<T, T2, T3, T5> Obsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T4 val)
        {
            return new Func<T, T2, T3, T5>((T a, T2 b, T3 c) => self(a, b, c, val));
        }

        public static Func<T2, T3, T4> Obsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T val)
        {
            return new Func<T2, T3, T4>((T2 a, T3 b) => self(val, a, b));
        }
        public static Func<T, T3, T4> Obsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T2 val)
        {
            return new Func<T, T3, T4>((T a, T3 b) => self(a, val, b));
        }
        public static Func<T, T2, T4> Obsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T3 val)
        {
            return new Func<T, T2, T4>((T a, T2 b) => self(a, b, val));
        }


        public static Func<T2, T3> Obsolesce<T, T2, T3>(this Func<T, T2, T3> self, T val)
        {
            return new Func<T2, T3>((T2 a) => self(val, a));
        }
        public static Func<T, T3> Obsolesce<T, T2, T3>(this Func<T, T2, T3> self, T2 val)
        {
            return new Func<T, T3>((T a) => self(a, val));
        }

        public static Func<T2> Obsolesce<T, T2>(this Func<T, T2> self, T val)
        {
            return new Func<T2>(() => self(val));
        }
    }
}
