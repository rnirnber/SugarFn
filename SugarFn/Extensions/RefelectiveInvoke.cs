using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static T2 ReflectiveInvoke<T, T2>(this Func<T, T2> self, object arg)
        {
            T a = default(T);
            Type t = typeof(T);
            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if(prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[]{});
                    if(o.GetType().FullName == t.FullName)
                    {
                        a = (T) o;
                    }
                }
            });
            return self(a);
        }
        public static List<T2> ReflectiveInvoke<T, T2, T3>(this Func<T, T2> self, List<T3> arg)
        {
            List<T2> ret_list = new List<T2>();
            arg.ForEach((T3 a) => ret_list.Add(self.ReflectiveInvoke<T, T2>(a)));
            return ret_list;
        }
        public static T3 ReflectiveInvoke<T, T2, T3>(this Func<T, T2, T3> self, object arg)
        {
            T a = default(T);
            T2 b = default(T2);

            Type t = typeof(T);
            Type t2 = typeof(T2);
            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict['a'] = false;
            assignment_dict['b'] = false;
            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if(prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[] { });
                    Type type = o.GetType();
                    if (type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T)o;
                        assignment_dict['a'] = true;
                    }
                    else if (type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2)o;
                        assignment_dict['b'] = true;
                    }
                }
            });
            return self(a, b);
        }
        public static List<T3> ReflectiveInvoke<T, T2, T3, T4>(this Func<T, T2, T3> self, List<T4> arg)
        {
            List<T3> ret_list = new List<T3>();
            arg.ForEach((T4 o) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3>(o)));
            return ret_list;
        }
        public static T4 ReflectiveInvoke<T, T2, T3, T4>(this Func<T, T2, T3, T4> self, object arg)
        {
            Type t = typeof(T);
            Type t2 = typeof(T2);
            Type t3 = typeof(T3);

            T a = default(T);
            T2 b = default(T2);
            T3 c = default(T3);

            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict.Add('a', false);
            assignment_dict.Add('b', false);
            assignment_dict.Add('c', false);
            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if(prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[]{});
                    Type type = o.GetType();
                    if(type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T) o;
                        assignment_dict['a'] = true;
                    }
                    else if(type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2) o;
                        assignment_dict['b'] = true;
                    }
                    else if(type.FullName == t3.FullName && !assignment_dict['c'])
                    {
                        c = (T3) o;
                        assignment_dict['c'] = true;
                    }
                }
            });
            return self(a, b, c);
        }
        public static List<T4> ReflectiveInvoke<T, T2, T3, T4, T5>(this Func<T, T2, T3, T4> self, List<T5> arg)
        {
            List<T4> ret_list = new List<T4>();
            arg.ForEach((T5 a) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3, T4>(a)));
            return ret_list;
        }
        public static T5 ReflectiveInvoke<T, T2, T3, T4, T5> (this Func<T, T2, T3, T4, T5> self, object arg)
        {
            Type t = typeof(T);
            Type t2 = typeof(T2);
            Type t3 = typeof(T3);
            Type t4 = typeof(T4);

            T a = default(T);
            T2 b = default(T2);
            T3 c = default(T3);
            T4 d = default(T4);

            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict.Add('a', false);
            assignment_dict.Add('b', false);
            assignment_dict.Add('c', false);
            assignment_dict.Add('d', false);

            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if (prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[] { });
                    Type type = o.GetType();
                    if (type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T)o;
                        assignment_dict['a'] = true;
                    }
                    else if (type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2)o;
                        assignment_dict['b'] = true;
                    }
                    else if (type.FullName == t3.FullName && !assignment_dict['c'])
                    {
                        c = (T3)o;
                        assignment_dict['c'] = true;
                    }
                    else if (type.FullName == t4.FullName && !assignment_dict['d'])
                    {
                        d = (T4)o;
                        assignment_dict['d'] = true;
                    }
                }
            });
            return self(a, b, c, d);
        }
        public static List<T5> ReflectiveInvoke<T, T2, T3, T4, T5, T6>(this Func<T, T2, T3, T4, T5> self, List<T6> arg)
        {
            List<T5> ret_list = new List<T5>();
            arg.ForEach((T6 a) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3, T4, T5>(a)));
            return ret_list;
        }
        public static T6 ReflectiveInvoke<T, T2, T3, T4, T5, T6> (this Func<T, T2, T3, T4, T5, T6> self, object arg)
        {
            Type t = typeof(T);
            Type t2 = typeof(T2);
            Type t3 = typeof(T3);
            Type t4 = typeof(T4);
            Type t5 = typeof(T5);

            T a = default(T);
            T2 b = default(T2);
            T3 c = default(T3);
            T4 d = default(T4);
            T5 e = default(T5);

            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict.Add('a', false);
            assignment_dict.Add('b', false);
            assignment_dict.Add('c', false);
            assignment_dict.Add('d', false);
            assignment_dict.Add('e', false);

            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if(prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[] { });
                    Type type = o.GetType();

                    if(type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T) o;
                        assignment_dict['a'] = true;
                    }
                    else if(type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2) o;
                        assignment_dict['b'] = true;
                    }
                    else if(type.FullName == t3.FullName && !assignment_dict['c'])
                    {
                        c = (T3) o;
                        assignment_dict['c'] = true;
                    }
                    else if(type.FullName == t4.FullName && !assignment_dict['d'])
                    {
                        d = (T4) o;
                        assignment_dict['d'] = true;
                    }
                    else if(type.FullName == t5.FullName && !assignment_dict['e'])
                    {
                        e = (T5) o;
                        assignment_dict['e'] = true;
                    }
                }
            });
            return self(a, b, c, d, e);
        }
        public static List<T6> ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6> self, List<T7> arg)
        {
            List<T6> ret_list = new List<T6>();
            arg.ForEach((T7 a) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3, T4, T5, T6>(a)));
            return ret_list;

        }
        public static T7 ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7>(this Func<T, T2, T3, T4, T5, T6, T7> self, object arg)
        {
            Type t = typeof(T);
            Type t2 = typeof(T2);
            Type t3 = typeof(T3);
            Type t4 = typeof(T4);
            Type t5 = typeof(T5);
            Type t6 = typeof(T6);

            T a = default(T);
            T2 b = default(T2);
            T3 c = default(T3);
            T4 d = default(T4);
            T5 e = default(T5);
            T6 f = default(T6);

            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict.Add('a', false);
            assignment_dict.Add('b', false);
            assignment_dict.Add('c', false);
            assignment_dict.Add('d', false);
            assignment_dict.Add('e', false);
            assignment_dict.Add('f', false);

            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if (prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[] { });
                    Type type = o.GetType();

                    if (type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T)o;
                        assignment_dict['a'] = true;
                    }
                    else if (type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2)o;
                        assignment_dict['b'] = true;
                    }
                    else if (type.FullName == t3.FullName && !assignment_dict['c'])
                    {
                        c = (T3)o;
                        assignment_dict['c'] = true;
                    }
                    else if (type.FullName == t4.FullName && !assignment_dict['d'])
                    {
                        d = (T4)o;
                        assignment_dict['d'] = true;
                    }
                    else if (type.FullName == t5.FullName && !assignment_dict['e'])
                    {
                        e = (T5)o;
                        assignment_dict['e'] = true;
                    }
                    else if (type.FullName == t6.FullName && !assignment_dict['f'])
                    {
                        f = (T6)o;
                        assignment_dict['f'] = true;
                    }
                }
            });
            return self(a, b, c, d, e, f);
        }
        public static List<T7> ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7> self, List<T8> arg)
        {
            List<T7> ret_list = new List<T7>();
            arg.ForEach((T8 a) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7>(a)));
            return ret_list;
        }
        public static T8 ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7, T8>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, object arg)
        {
            Type t = typeof(T);
            Type t2 = typeof(T2);
            Type t3 = typeof(T3);
            Type t4 = typeof(T4);
            Type t5 = typeof(T5);
            Type t6 = typeof(T6);
            Type t7 = typeof(T7);

            T a = default(T);
            T2 b = default(T2);
            T3 c = default(T3);
            T4 d = default(T4);
            T5 e = default(T5);
            T6 f = default(T6);
            T7 g = default(T7);

            Dictionary<char, bool> assignment_dict = new Dictionary<char, bool>();
            assignment_dict.Add('a', false);
            assignment_dict.Add('b', false);
            assignment_dict.Add('c', false);
            assignment_dict.Add('d', false);
            assignment_dict.Add('e', false);
            assignment_dict.Add('f', false);
            assignment_dict.Add('g', false);

            arg.GetType().GetProperties().ToList<PropertyInfo>().ForEach((PropertyInfo prop) =>
            {
                if (prop.CanRead)
                {
                    MethodInfo method = prop.GetMethod;
                    object o = method.Invoke(arg, new object[] { });
                    Type type = o.GetType();

                    if (type.FullName == t.FullName && !assignment_dict['a'])
                    {
                        a = (T) o;
                        assignment_dict['a'] = true;
                    }
                    else if (type.FullName == t2.FullName && !assignment_dict['b'])
                    {
                        b = (T2)o;
                        assignment_dict['b'] = true;
                    }
                    else if (type.FullName == t3.FullName && !assignment_dict['c'])
                    {
                        c = (T3)o;
                        assignment_dict['c'] = true;
                    }
                    else if (type.FullName == t4.FullName && !assignment_dict['d'])
                    {
                        d = (T4)o;
                        assignment_dict['d'] = true;
                    }
                    else if (type.FullName == t5.FullName && !assignment_dict['e'])
                    {
                        e = (T5)o;
                        assignment_dict['e'] = true;
                    }
                    else if (type.FullName == t6.FullName && !assignment_dict['f'])
                    {
                        f = (T6)o;
                        assignment_dict['f'] = true;
                    }
                    else if(type.FullName == t7.FullName && !assignment_dict['g'])
                    {
                        g = (T7) o;
                        assignment_dict['g'] = true;
                    }
                }
            });
            return self(a, b, c, d, e, f, g);
        }
        public static List<T8> ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T, T2, T3, T4, T5, T6, T7, T8> self, List<T9> arg)
        {
            List<T8> ret_list = new List<T8>();
            arg.ForEach((T9 a) => ret_list.Add(self.ReflectiveInvoke<T, T2, T3, T4, T5, T6, T7, T8>(a)));
            return ret_list;
        }
    }
}
