using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<T2> RightSideObsolesce<T, T2>(this Func<T, T2> self, T val)
        {
            return new Func<T2>(() => self(val));
        }

        public static Func<T, T3> RightSideObsolesce<T, T2, T3>(this Func<T, T2, T3> self, T2 val)
        {
            return new Func<T, T3>((T a) => self(a, val));
        }
        public static Func<T3> RightSideObsolesce<T, T2, T3>(this Func<T, T2, T3> self, T2 val, T val2)
        {
            return new Func<T3>(() => self(val2, val));
        }

        public static Func<T, T2, T4> RightSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T3 val)
        {
            return new Func<T, T2, T4>((T a, T2 b) => self(a, b, val));
        }
        public static Func<T, T4> RightSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T3 val, T2 val2)
        {
            return new Func<T, T4>((T a) => self(a, val2, val));
        }
        public static Func<T4> RightSideObsolesce<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, T3 val, T2 val2, T val3)
        {
            return new Func<T4>(() => self(val3, val2, val));
        }

        public static Func<T, T2, T3, T5> RightSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T4 val)
        {
            return new Func<T, T2, T3, T5>((T a, T2 b, T3 c) => self(a, b, c, val));
        }
        public static Func<T, T2, T5> RightSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T4 val, T3 val2)
        {
            return new Func<T, T2, T5>((T a, T2 b) => self(a, b, val2, val));
        }
        public static Func<T, T5> RightSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T4 val, T3 val2, T2 val3)
        {
            return new Func<T, T5>((T a) => self(a, val3, val2, val));
        }
        public static Func<T5> RightSideObsolesce<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, T4 val, T3 val2, T2 val3, T val4)
        {
            return new Func<T5>(() => self(val4, val3, val2, val));
        }

        public static Func<T, T2, T3, T4, T6> RightSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val)
        {
            return new Func<T, T2, T3, T4, T6>((T a, T2 b, T3 c, T4 d) => self(a, b, c, d, val));
        }
        public static Func<T, T2, T3, T6> RightSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val, T4 val2)
        {
            return new Func<T, T2, T3, T6>((T a, T2 b, T3 c) => self(a, b, c, val2, val));
        }
        public static Func<T, T2, T6> RightSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val, T4 val2, T3 val3)
        {
            return new Func<T, T2, T6>((T a, T2 b) => self(a, b, val3, val2, val));
        }
        public static Func<T, T6> RightSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val, T4 val2, T3 val3, T2 val4)
        {
            return new Func<T, T6>((T a) => self(a, val4, val3, val2, val));
        }
        public static Func<T6> RightSideObsolesce<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, T5 val, T4 val2, T3 val3, T2 val4, T val5)
        {
            return new Func<T6>(() => self(val5, val4, val3, val2, val));
        }

        public static Func<T, T2, T3, T4, T5, T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val)
        {
            return new Func<T, T2, T3, T4, T5, T7>((T a, T2 b, T3 c, T4 d, T5 e) => self(a, b, c, d, e, val));
        }
        public static Func<T, T2, T3, T4, T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val, T5 val2)
        {
            return new Func<T, T2, T3, T4, T7>((T a, T2 b, T3 c, T4 d) => self(a, b, c, d, val2, val));
        }
        public static Func<T, T2, T3, T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val, T5 val2, T4 val3)
        {
            return new Func<T, T2, T3, T7>((T a, T2 b, T3 c) => self(a, b, c, val3, val2, val));
        }
        public static Func<T, T2, T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val, T5 val2, T4 val3, T3 val4)
        {
            return new Func<T, T2, T7>((T a, T2 b) => self(a, b, val4, val3, val2, val));
        }
        public static Func<T, T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val, T5 val2, T4 val3, T3 val4, T2 val5)
        {
            return new Func<T, T7>((T a) => self(a, val5, val4, val3, val2, val));
        }
        public static Func<T7> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, T6 val, T5 val2, T4 val3, T3 val4, T2 val5, T val6)
        {
            return new Func<T7>(() => self(val6, val5, val4, val3, val2, val));
        }
        public static Func<T, T2, T3, T4, T5, T6, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val)
        {
            return new Func<T, T2, T3, T4, T5, T6, T8>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(a, b, c, d, e, f, val));
        }
        public static Func<T, T2, T3, T4, T5, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2)
        {
            return new Func<T, T2, T3, T4, T5, T8>((T a, T2 b, T3 c, T4 d, T5 e) => self(a, b, c, d, e, val2, val));
        }
        public static Func<T, T2, T3, T4, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2, T5 val3)
        {
            return new Func<T, T2, T3, T4, T8>((T a, T2 b, T3 c, T4 d) => self(a, b, c, d, val3, val2, val));
        }
        public static Func<T, T2, T3, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2, T5 val3, T4 val4)
        {
            return new Func<T, T2, T3, T8>((T a, T2 b, T3 c) => self(a, b, c, val4, val3, val2, val));
        }
        public static Func<T, T2, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2, T5 val3, T4 val4, T3 val5)
        {
            return new Func<T, T2, T8>((T a, T2 b) => self(a, b, val5, val4, val3, val2, val));
        }
        public static Func<T, T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2, T5 val3, T4 val4, T3 val5, T2 val6)
        {
            return new Func<T, T8>((T a) => self(a, val6, val5, val4, val3, val2, val));
        }
        public static Func<T8> RightSideObsolesce<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, T7 val, T6 val2, T5 val3, T4 val4, T3 val5, T2 val6, T val7)
        {
            return new Func<T8>(() => self(val7, val6, val5, val4, val3, val2, val));
        }
    }
}
