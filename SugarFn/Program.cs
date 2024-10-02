using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SugarFn.Extensions;
namespace SugarFn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Testing all features of SugarFN*/

            // Example of "AND", single parameter
            var is_even = (Func<int, bool>) ((int x) => x % 2 == 0);
            var is_even_and_is_divisible_by_ten = is_even.AND<int>((int x) => x % 10 == 0);

            Console.WriteLine("========================");
            Console.WriteLine("Single argument 'AND'ing");
            Console.WriteLine("========================");
            Console.WriteLine("Is 6 even?");
            Console.WriteLine(is_even(6));

            Console.WriteLine("is 5 even?");
            Console.WriteLine(is_even(5));

            Console.WriteLine("Is thirty evenly divisible by 10?");
            Console.WriteLine(is_even_and_is_divisible_by_ten(30));

            Console.WriteLine("Is 45 evenly divisible by 10?");
            Console.WriteLine(is_even_and_is_divisible_by_ten(45));

            var is_left_parameter_greater_than_right_parameter = ((Func<int, int, bool>)((x, y) => x > y));
            var is_left_parameter_more_than_double_left_parameter = is_left_parameter_greater_than_right_parameter.AND<int, int>((Func<int, int, bool>)((x, y) => (x / 2) > y));

            Console.WriteLine("\n\n");

            // Example of "AND", multiple parameters
            Console.WriteLine("================");
            Console.WriteLine("Multiple argument 'AND'ing");
            Console.WriteLine("================");

            Console.WriteLine("Is 5 greater than 2?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter(5, 2));
            Console.WriteLine("Is 5 greater than 10?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter(5, 10));

            Console.WriteLine("Is 25 more than double of 10?");
            Console.WriteLine(is_left_parameter_more_than_double_left_parameter(25, 10));
            Console.WriteLine("Is 30 more than double of 20");
            Console.WriteLine(is_left_parameter_more_than_double_left_parameter(30, 20));
            
            // Example of single parameter 'OR'ing
            Console.WriteLine("==============");
            Console.WriteLine("Single argument 'OR'ing");
            Console.WriteLine("=============");

            var is_even2 = (Func<int, bool>)((int x) => x % 2 == 0);
            var is_even_or_evenly_divisible_by_three = is_even.OR<int>((int a) => a % 3 == 0);

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine("Is " + i.ToString() + " even or evenly divisible by 3?");
                Console.WriteLine(is_even_or_evenly_divisible_by_three(i));
            }
            Console.WriteLine("\n\n");

            // Example of multiple parameter 'OR'ing
            Console.WriteLine("===============");
            Console.WriteLine("Multiple parameter 'OR'ing");
            Console.WriteLine("===============");

            var is_left_parameter_greater_than_right_parameter_v2 = (Func<int, int, bool>)((int x, int y) => x > y);
            var is_left_parameter_greater_than_right_parameter_or_right_parameter_is_100 = is_left_parameter_greater_than_right_parameter_v2.OR<int, int>((x, y) => y == 100);

            Console.WriteLine("Is 20 greater than 10?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter_v2(20, 10));
            Console.WriteLine("Is 10 greater than 20?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter_v2(10, 20));
            Console.WriteLine("Is 75 greater than 1, or is 1 100?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter_or_right_parameter_is_100(75, 1));
            Console.WriteLine("Is 0 greater than 100, or is 100 100?");
            Console.WriteLine(is_left_parameter_greater_than_right_parameter_or_right_parameter_is_100(0, 100));

            // "NOT'ing" examples...
            
            Console.WriteLine("\n\n");
            Console.WriteLine("================");
            Console.WriteLine("'NOT'ing w/1 parameter...");
            Console.WriteLine("================");

            var is_name_raymond = (Func<string, bool>)((str) => str == "Raymond");
            var is_name_not_raymond = is_name_raymond.NOT<string>();

            Console.WriteLine("Is Adam Raymond?");
            Console.WriteLine(is_name_raymond("Adam"));
            Console.WriteLine("Is Raymond Raymond?");
            Console.WriteLine(is_name_raymond("Raymond"));

            Console.WriteLine("Is Raymond not Raymond?");
            Console.WriteLine(is_name_not_raymond("Raymond"));
            Console.WriteLine("Is Adam not Raymond?");
            Console.WriteLine(is_name_not_raymond("Adam"));

            Console.WriteLine("\n\n");
            Console.WriteLine("================");
            Console.WriteLine("'NOT'ing w/multiple parameters...");
            Console.WriteLine("================");

            var names_list_one = new List<string>() { "Adam", "Bob", "Raymond" };
            var names_list_two = new List<string>() { "Fabian", "Richard", "Peter" };
            var is_raymond_in_list = (Func<string, List<string>, bool>)((name, n_list) => n_list.Contains("Raymond"));
            var is_raymond_not_in_list = is_raymond_in_list.NOT();
            var is_peter_in_list = (Func<string, List<string>, bool>)((name, n_list) => n_list.Contains("Peter"));
            var is_peter_not_in_list = is_peter_in_list.NOT();

            Console.WriteLine("Is Raymond in List 1");
            Console.WriteLine(is_raymond_in_list("Raymond", names_list_one));
            Console.WriteLine("Is Peter in List 1?");
            Console.WriteLine(is_peter_in_list("Peter", names_list_one));
            Console.WriteLine("Is Peter not in list 2?");
            Console.WriteLine(is_peter_not_in_list("Peter", names_list_two));
            Console.WriteLine("Is Raymond not in list 2?");
            Console.WriteLine(is_raymond_not_in_list("Raymond", names_list_two));

            // First and Last...
            Console.WriteLine("\n\n");
            Console.WriteLine("=============");
            Console.WriteLine("First and Last (List/Collection extension methods");
            Console.WriteLine("=============");

            Console.WriteLine("Is Adam the first person in list 1?");
            Console.WriteLine(names_list_one.IsFirst<string>("Adam"));
            Console.WriteLine("Is Raymond the first person in list 1?");
            Console.WriteLine(names_list_one.IsFirst<string>("Raymond"));

            Console.WriteLine("\n\n===========");
            Console.WriteLine("Is Raymond the last person in list 1?");
            Console.WriteLine(names_list_one.IsLast<string>("Raymond"));
            Console.WriteLine("Is Adam the last person in list 1?");
            Console.WriteLine(names_list_one.IsLast<string>("Adam"));

            Console.WriteLine("\n\n=========");
            Console.WriteLine("Left-Side Obsolesce");
            Console.WriteLine("=============");

            // original FN, sum 3 numbers
            var left_side_fn1 = (Func<int, int, int, int>)((a, b, c) => a + b + c);
            // hardcode 1st (left-to-right) parameter to be 50
            var left_side_fn2 = left_side_fn1.LeftSideObsolesce<int, int, int, int>(50);
            Console.WriteLine("Are we getting 50 + 10 + 10 (70) ???");
            Console.WriteLine(left_side_fn2(10, 10));

            // hardcode 2nd parameter to be 25
            var left_side_fn3 = left_side_fn2.LeftSideObsolesce<int, int, int>(25);
            Console.WriteLine("Are we getting 50 + 25 + 5 (80) ???");
            Console.WriteLine(left_side_fn3(5));
            // hardcode 3rd parameter to be 25
            var left_side_fn4 = left_side_fn3.LeftSideObsolesce<int, int>(25);
            Console.WriteLine("Are we getting 50 + 25 + 25 (100) ???");
            Console.WriteLine(left_side_fn4());

            Console.WriteLine("\n\n=========");
            Console.WriteLine("Right-Side Obsolesce");
            Console.WriteLine("=============");

            // going from right-to-left
            var right_side_fn1 = (Func<int, int, int, int>)((a, b, c) => a + b + c);
            // hardcode value of 500 to 'c'
            var right_side_fn2 = right_side_fn1.RightSideObsolesce<int, int, int, int>(500);
            Console.WriteLine("Are we getting 100 + 100 + 500 (700) ???");
            Console.WriteLine(right_side_fn2(100, 100));
            var right_side_fn3 = right_side_fn2.RightSideObsolesce<int, int, int>(50);
            Console.WriteLine("Are we getting 1000 + 50 + 500 (1550) ???");
            Console.WriteLine(right_side_fn3(1000));
            var right_side_fn4 = right_side_fn3.RightSideObsolesce<int, int>(1);
            Console.WriteLine("Are we getting 500 + 50 + + 1 (551) ???");
            Console.WriteLine(right_side_fn4());

            Console.WriteLine("Press any key to exit");
            var ignore_this = Console.ReadLine();
        }
    }
    
}

