using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    public class Square
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                double square = Math.Sqrt(numbers[i]);
                if (square == (int) square)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort();
            result.Reverse();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}