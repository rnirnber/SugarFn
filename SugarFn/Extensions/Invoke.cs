using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static List<T2> Invoke<T, T2> (this Func<T, T2> self, List<T> args)
        {
            List<T2> ret_list = new List<T2>();
            args.ForEach((T a) => ret_list.Add(self(a)));
            return ret_list;
        }
        public static List<T3> Invoke<T, T2, T3> (this Func<T, T2, T3> self, List<T> args1, List<T2> args2)
        {
            List<T3> ret_list = new List<T3>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count]));
                count++;
            });
            return ret_list;
        }
        public static List<T4> Invoke<T, T2, T3, T4> (this Func<T, T2, T3, T4> self, List<T> args1, List<T2> args2, List<T3> args3)
        {
            List<T4> ret_list = new List<T4>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count], args3[count]));
                count++;
            });
            return ret_list;
        }
        public static List<T5> Invoke<T, T2, T3, T4, T5> (this Func<T, T2, T3, T4, T5> self, List<T> args1, List<T2> args2, List<T3> args3, List<T4> args4)
        {
            List<T5> ret_list = new List<T5>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count], args3[count], args4[count]));
                count++;
            });
            return ret_list;
        }
        public static List<T6> Invoke<T, T2, T3, T4, T5, T6> (this Func<T, T2, T3, T4, T5, T6> self, List<T> args1, List<T2> args2, List<T3> args3, List<T4> args4, List<T5> args5)
        {
            List<T6> ret_list = new List<T6>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count], args3[count], args4[count], args5[count]));
                count++;
            });
            return ret_list;
        }
        public static List<T7> Invoke<T, T2, T3, T4, T5, T6, T7> (this Func<T, T2, T3, T4, T5, T6, T7> self, List<T> args1, List<T2> args2, List<T3> args3, List<T4> args4, List<T5> args5, List<T6> args6)
        {
            List<T7> ret_list = new List<T7>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count], args3[count], args4[count], args5[count], args6[count]));
                count++;
            });
            return ret_list;
        }
        public static List<T8> Invoke<T, T2, T3, T4, T5, T6, T7, T8> (this Func<T, T2, T3, T4, T5, T6, T7, T8> self, List<T> args1, List<T2> args2, List<T3> args3, List<T4> args4, List<T5> args5, List<T6> args6, List<T7> args7)
        {
            List<T8> ret_list = new List<T8>();
            int count = 0;
            args1.ForEach((T a) =>
            {
                ret_list.Add(self(a, args2[count], args3[count], args4[count], args5[count], args6[count], args7[count]));
            });
            return ret_list;
        }
    }
}
