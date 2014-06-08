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
            Func<string, string, string, string, string, string, string, string> fn =
                ((string a, string b, string c, string d, string e, string f, string g) => a + b + c + d + e + f + g);
            Func<string, string, string, string, string, string> fn2 = fn.LeftSideObsolesce<string, string, string, string, string, string, string, string>("foo", "bar");
            Func<string, string, string, string, string, string> fn3 = fn.RightSideObsolesce<string, string, string, string, string, string, string, string>("bar", "foo");
            Func<string, string, string, string, string, string, string> fn4 = fn.Obsolesce<string, string, string, string, string, string, string, string>("foobar");
            Console.WriteLine(fn2("", "", "", "", ""));
            Console.WriteLine(fn3("", "", "", "", ""));
        }
    }
    public static partial class __SugarFnExtensions
    {
        
    }
}

