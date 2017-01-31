using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    public class Count
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);
            int previous = numbers[0];
            int count = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == previous)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{previous} -> {count}");
                    count = 1;
                }
                previous = numbers[i];
            }

        }
    }
}