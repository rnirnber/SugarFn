using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static List<T2> DynamicInvoke<T, T2>(this Func<T, T2> self, List<object[]> args)
        {
            List<T2> ret_list = new List<T2>();
            args.ForEach((object[] o) => ret_list.Add((T2) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T3> DynamicInvoke<T, T2, T3>(this Func<T, T2, T3> self, List<object[]> args)
        {
            List<T3> ret_list = new List<T3>();
            args.ForEach((object[] o) => ret_list.Add((T3) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T4> DynamicInvoke<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, List<object[]> args)
        {
            List<T4> ret_list = new List<T4>();
            args.ForEach((object[] o) => ret_list.Add((T4) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T5> DynamicInvoke<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4, T5> self, List<object[]> args)
        {
            List<T5> ret_list = new List<T5>();
            args.ForEach((object[] o) => ret_list.Add((T5) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T6> DynamicInvoke<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5, T6> self, List<object[]> args)
        {
            List<T6> ret_list = new List<T6>();
            args.ForEach((object[] o) => ret_list.Add((T6) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T7> DynamicInvoke<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, List<object[]> args)
        {
            List<T7> ret_list = new List<T7>();
            args.ForEach((object[] o) => ret_list.Add((T7) self.DynamicInvoke(o)));
            return ret_list;
        }
        public static List<T8> DynamicInvoke<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, List<object[]> args)
        {
            List<T8> ret_list = new List<T8>();
            args.ForEach((object[] o) => ret_list.Add((T8) self.DynamicInvoke(o)));
            return ret_list;
        }
    }
}
