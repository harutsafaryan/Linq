using System;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 52, 41, 58, 5 };
            int[] arr = new int[] { 5, 4, 2, 3, 6, 5, 8, 15, 254, 78, 5 };

            var result = arr._Where(item => item > 15);
            var result1 = arr._Take(3); 
            var result2 = arr._TakeWhile(item => item % 2 == 1);
            var result3 = arr._Union(list);
            var result4 = arr._Intersect(list);
            var result5 = arr._Except(list);
            var result6 = arr._Reverse();
            var result7 = arr._First();
            var result8 = arr._First(item => item % 3 == 0);
            var result9 = arr._FirstOrDefault(item => item % 7 == 0);
            Console.WriteLine();

        }
    }
}
