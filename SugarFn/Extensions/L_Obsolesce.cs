using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<T2> LeftSideObsolesce<T, T2>(this Func<T, T2> self, T val)
        {
            return new Func<T2>(() => self(val));
        }

        public static Func<T2, T3> LeftSideObsolesce<T, T2, T3>(this Func<T, T2, T3> self, T val)
        {
            return new Func<T2, T3>((T2 a) => self(val, a));
        }
        public static Func<T3> LeftSideObsolesce<T, T2, T3>(this Func<T, T2, T3> self, T val, T2 val2)
        {
            return new Func<T3>(() => self(val, val2));
        }

        public static Func<T2, T3, T4> LeftSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T val)
        {
            return new Func<T2, T3, T4>((T2 a, T3 b) => self(val, a, b));
        }
        public static Func<T3, T4> LeftSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T val, T2 val2)
        {
            return new Func<T3, T4>((T3 a) => self(val, val2, a));
        }
        public static Func<T4> LeftSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T val, T2 val2, T3 val3)
        {
            return new Func<T4>(() => self(val, val2, val3));
        }

        public static Func<T2, T3, T4, T5> LeftSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T val)
        {
            return new Func<T2, T3, T4, T5>((T2 a, T3 b, T4 c) => self(val, a, b, c));
        }
        public static Func<T3, T4, T5> LeftSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T val, T2 val2)
        {
            return new Func<T3, T4, T5>((T3 a, T4 b) => self(val, val2, a, b));
        }
        public static Func<T4, T5> LeftSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T val, T2 val2, T3 val3)
        {
            return new Func<T4, T5>((T4 a) => self(val, val2, val3, a));
        }
        public static Func<T5> LeftSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T val, T2 val2, T3 val3, T4 val4)
        {
            return new Func<T5>(() => self(val, val2, val3, val4));
        }

        public static Func<T2, T3, T4, T5, T6> LeftSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6>((T2 a, T3 b, T4 c, T5 d) => self(val, a, b, c, d));
        }
        public static Func<T3, T4, T5, T6> LeftSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T val, T2 val2)
        {
            return new Func<T3, T4, T5, T6>((T3 a, T4 b, T5 c) => self(val, val2, a, b, c));
        }
        public static Func<T4, T5, T6> LeftSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T val, T2 val2, T3 val3)
        {
            return new Func<T4, T5, T6>((T4 a, T5 b) => self(val, val2, val3, a, b));
        }
        public static Func<T5, T6> LeftSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T val, T2 val2, T3 val3, T4 val4)
        {
            return new Func<T5, T6>((T5 a) => self(val, val2, val3, val4, a));
        }
        public static Func<T6> LeftSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T val, T2 val2, T3 val3, T4 val4, T5 val5)
        {
            return new Func<T6>(() => self(val, val2, val3, val4, val5));
        }
        public static Func<T2, T3, T4, T5, T6, T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6, T7>((T2 a, T3 b, T4 c, T5 d, T6 e) => self(val, a, b, c, d, e));
        }
        public static Func<T3, T4, T5, T6, T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val, T2 val2)
        {
            return new Func<T3, T4, T5, T6, T7>((T3 a, T4 b, T5 c, T6 d) => self(val, val2, a, b, c, d));
        }
        public static Func<T4, T5, T6, T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val, T2 val2, T3 val3)
        {
            return new Func<T4, T5, T6, T7>((T4 a, T5 b, T6 c) => self(val, val2, val3, a, b, c));
        }
        public static Func<T5, T6, T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val, T2 val2, T3 val3, T4 val4)
        {
            return new Func<T5, T6, T7>((T5 a, T6 b) => self(val, val2, val3, val4, a, b));
        }
        public static Func<T6, T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val, T2 val2, T3 val3, T4 val4, T5 val5)
        {
            return new Func<T6, T7>((T6 a) => self(val, val2, val3, val4, val5, a));
        }
        public static Func<T7> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T val, T2 val2, T3 val3, T4 val4, T5 val5, T6 val6)
        {
            return new Func<T7>(() => self(val, val2, val3, val4, val5, val6));
        }
        public static Func<T2, T3, T4, T5, T6, T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val)
        {
            return new Func<T2, T3, T4, T5, T6, T7, T8>((T2 a, T3 b, T4 c, T5 d, T6 e, T7 f) => self(val, a, b, c, d, e, f));
        }
        public static Func<T3, T4, T5, T6, T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2)
        {
            return new Func<T3, T4, T5, T6, T7, T8>((T3 a, T4 b, T5 c, T6 d, T7 e) => self(val, val2, a, b, c, d, e));
        }
        public static Func<T4, T5, T6, T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2, T3 val3)
        {
            return new Func<T4, T5, T6, T7, T8>((T4 a, T5 b, T6 c, T7 d) => self(val, val2, val3, a, b, c, d));
        }
        public static Func<T5, T6, T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2, T3 val3, T4 val4)
        {
            return new Func<T5, T6, T7, T8>((T5 a, T6 b, T7 c) => self(val, val2, val3, val4, a, b, c));
        }
        public static Func<T6, T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2, T3 val3, T4 val4, T5 val5)
        {
            return new Func<T6, T7, T8>((T6 a, T7 b) => self(val, val2, val3, val4, val5, a, b));
        }
        public static Func<T7, T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2, T3 val3, T4 val4, T5 val5, T6 val6)
        {
            return new Func<T7, T8>((T7 a) => self(val, val2, val3, val4, val5, val6, a));
        }
        public static Func<T8> LeftSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T val, T2 val2, T3 val3, T4 val4, T5 val5, T6 val6, T7 val7)
        {
            return new Func<T8>(() => self(val, val2, val3, val4, val5, val6, val7));
        }
    }
}
