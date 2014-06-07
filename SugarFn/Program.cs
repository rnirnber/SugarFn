using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SugarFn.Extensions;
namespace SugarFn
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> str_equals = ((string x, string y) => x == y);
            Func<string, int, bool> str_equals_int = ((string x, int y) => x == y.ToString());
            str_equals = str_equals.AND<string, string>((string x, string y) => x.GetHashCode() == y.GetHashCode());
        }
    }
    public static partial class __SugarFnExtensions
    {
        
    }
}

