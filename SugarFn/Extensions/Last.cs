using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarFn.Extensions
{
    public static partial class _____SugarFnExtensions
    {
        public static bool IsLast<T>(this ReadOnlyCollection<T> self, T item)
        {
            return item.GetHashCode() == self.Last().GetHashCode();
        }

        public static bool IsLast<T>(this List<T> self, T item)
        {
            return item.GetHashCode() == self.Last().GetHashCode();
        }
    }
}
