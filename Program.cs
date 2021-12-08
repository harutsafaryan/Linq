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

            var result = _Enumerable.Where(arr, item => item > 15);
            var result1 = _Enumerable.Take(arr, 3);
            var result2 = _Enumerable.TakeWhile(arr, item => item % 2 == 1);
            var result3 = _Enumerable.Union(arr, list);
            var result4 = _Enumerable.Intersect(arr, list);
            var result5 = _Enumerable.Except(arr, list);
            var result6 = _Enumerable.Reverse(arr);
            var result7 = _Enumerable.First(arr);
            var result8 = _Enumerable.First(arr, item => item % 3 == 0);
            var result9 = _Enumerable.FirstOrDefault(arr, item => item % 7 == 0);
            Console.WriteLine();

        }
    }
}
