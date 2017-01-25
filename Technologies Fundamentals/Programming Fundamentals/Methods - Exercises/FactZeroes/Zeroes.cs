using System;

namespace FactZeroes
{
    class Zeroes
    {
        public static int TrailingZeroes(int num)
        {
            int count = 0;

            for (int i = 5; num / i >= 1; i *= 5)
            {
                count += num / i;
            }

            return count;
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(number));
        }
    }
}