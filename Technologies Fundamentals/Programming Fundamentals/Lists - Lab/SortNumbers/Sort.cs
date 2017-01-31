using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    public class Sort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}