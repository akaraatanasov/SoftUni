using System;
using System.Collections.Generic;
using System.Linq;

namespace SumRevNumbers
{
    public class Sum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += Reverse(numbers[i]);
            }

            Console.WriteLine(sum);
        }

        public static int Reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}