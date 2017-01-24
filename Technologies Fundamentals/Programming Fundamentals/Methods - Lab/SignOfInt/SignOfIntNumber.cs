using System;

namespace SignOfInt
{
    class SignOfIntNumber
    {
        public static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
    }
}