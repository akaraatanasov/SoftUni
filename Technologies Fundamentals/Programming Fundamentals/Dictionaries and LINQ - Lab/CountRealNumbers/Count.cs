using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    public class Count
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var dictionary = new SortedDictionary<double, int>();

            foreach (var number in list)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }

                dictionary[number]++;
            }

            foreach (var number in dictionary.Keys)
            {
                Console.WriteLine($"{number} -> {dictionary[number]} times");
            }
        }
    }
}