using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static bool First<T>(this ReadOnlyCollection<T> self, T item)
        {
            return item.GetHashCode() == self.First().GetHashCode();
        }

        public static bool First<T>(this List<T> self, T item)
        {
            return item.GetHashCode() == self.First().GetHashCode();
        }
    }
}

/*
 * public static bool Last<T>(this ReadOnlyCollection<T> self, T item)
        {
            return item.GetHashCode() == self.Last().GetHashCode();
        }

        public static bool First<T>(this ReadOnlyCollection<T> self, T item)
        {
            return item.GetHashCode() == self.First().GetHashCode();
        }*/
