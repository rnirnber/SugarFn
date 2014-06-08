using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static Func<bool> AND(this Func<bool> self, Func<bool> fn)
        {
            return new Func<bool>(() => self() && fn());
        }
        public static Func<T, bool> AND<T>(this Func<bool> self, Func<T, bool> fn)
        {
            return new Func<T, bool>((T a) => self() && (fn(a)));
        }
        public static Func<T, bool> AND<T>(this Func<T, bool> self, Func<T, bool> fn)
        {
            return new Func<T, bool>((T a) => self(a) && fn(a));
        }
        public static Func<T, T2, bool> AND<T, T2>(this Func<T, T2, bool> self, Func<T, T2, bool> fn)
        {
            return new Func<T, T2, bool>((T a, T2 b) => self(a, b) && fn(a, b));
        }
        public static Func<T, T2, T3, bool> AND<T, T2, T3>(this Func<T, T2, T3, bool> self, Func<T, T2, T3, bool> fn)
        {
            return new Func<T, T2, T3, bool>((T a, T2 b, T3 c) => self(a, b, c) && fn(a, b, c));
        }
        public static Func<T, T2, T3, T4, bool> AND<T, T2, T3, T4>(this Func<T, T2, T3, T4, bool> self, Func<T, T2, T3, T4, bool> fn)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => self(a, b, c, d) && fn(a, b, c, d));
        }
        public static Func<T, T2, T3, T4, T5, bool> AND<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5, bool> self, Func<T, T2, T3, T4, T5, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, bool>((T a, T2 b, T3 c, T4 d, T5 e) => self(a, b, c, d, e) && fn(a, b, c, d, e));
        }
        public static Func<T, T2, T3, T4, T5, T6, bool> AND<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6, bool> self, Func<T, T2, T3, T4, T5, T6, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(a, b, c, d, e, f) && fn(a, b, c, d, e, f));
        }
        public static Func<T, T2, T3, T4, T5, T6, T7, bool> AND<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7, bool> self, Func<T, T2, T3, T4, T5, T6, T7, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, T7, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => self(a, b, c, d, e, f, g) && fn(a, b, c, d, e, f, g));
        }



        public static Func<T, bool> AND<T>(this Func<T, bool> self, Func<bool> fn)
        {
            return new Func<T, bool>((T a) => self(a) && fn());
        }
        public static Func<T, T2, bool> AND<T, T2>(this Func<T, bool> self, Func<T2, bool> fn)
        {
            return new Func<T, T2, bool>((T a, T2 b) => self(a) && fn(b));
        }
        public static Func<T, T2, T3, bool> AND<T, T2, T3> (this Func<T, T2, bool> self, Func<T3, bool> fn)
        {
            return new Func<T, T2, T3, bool>((T a, T2 b, T3 c) => self(a, b) && fn(c));
        }
        public static Func<T, T2, T3, T4, bool> AND<T, T2, T3, T4>(this Func<T, T2, T3, bool> self, Func<T4, bool> fn)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => self(a, b, c) && fn(d));
        }
        public static Func<T, T2, T3, T4, T5, bool> AND<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, bool> self, Func<T5, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, bool>((T a, T2 b, T3 c, T4 d, T5 e) => self(a, b, c, d) && fn(e));
        }
        public static Func<T, T2, T3, T4, T5, T6, bool> AND<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, bool> self, Func<T6, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(a, b, c, d, e) && fn(f));
        }
        public static Func<T, T2, T3, T4, T5, T6, T7, bool> AND<T, T2, T3, T4, T5, T6, T7> (this Func<T, T2, T3, T4, T5, T6, bool> self, Func<T7, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, T7, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => self(a, b, c, d, e, f) && fn(g));
        }



        public static Func<T, T2, bool> AND<T, T2>(this Func<T2, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, bool>((T a, T2 b) => self(b) && fn(a));
        }
        public static Func<T, T2, T3, bool> AND<T, T2, T3>(this Func<T2, T3, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, T3, bool>((T a, T2 b, T3 c) => self(b, c) && fn(a));
        }
        public static Func<T, T2, T3, T4, bool> AND<T, T2, T3, T4>(this Func<T2, T3, T4, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => self(b, c, d) && fn(a));
        }
        public static Func<T, T2, T3, T4, T5, bool> AND<T, T2, T3, T4, T5>(this Func<T2, T3, T4, T5, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, bool>((T a, T2 b, T3 c, T4 d, T5 e) => self(b, c, d, e) && fn(a));
        }
        public static Func<T, T2, T3, T4, T5, T6, bool> AND<T, T2, T3, T4, T5, T6>(this Func<T2, T3, T4, T5, T6, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(b, c, d, e, f) && fn(a));
        }
        public static Func<T, T2, T3, T4, T5, T6, T7, bool> AND<T, T2, T3, T4, T5, T6, T7>(this Func<T2, T3, T4, T5, T6, T7, bool> self, Func<T, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, T7, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => self(b, c, d, e, f, g) && fn(a));
        }



        public static Func<T, T2, T3, T4, bool> AND<T, T2, T3, T4>(this Func<T, T2, bool> self, Func<T3, T4, bool> fn)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => self(a, b) && fn(c, d));
        }
        public static Func<T, T2, T3, T4, bool> AND<T, T2, T3, T4>(this Func<T3, T4, bool> self, Func<T, T2, bool> fn)
        {
            return new Func<T, T2, T3, T4, bool>((T a, T2 b, T3 c, T4 d) => self(c, d) && fn(a, b));
        }
        public static Func<T, T2, T3, T4, T5, T6, bool> AND<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, bool> self, Func<T4, T5, T6, bool> fn)
        {
            return new Func<T, T2, T3, T4, T5, T6, bool>((T a, T2 b, T3 c, T4 d, T5 e, T6 f) => self(a, b, c) && fn(d, e, f));
        }

    }
}
