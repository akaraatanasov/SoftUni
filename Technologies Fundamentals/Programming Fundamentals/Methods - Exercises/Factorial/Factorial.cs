using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        public static BigInteger FactorialResult(int num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialResult(number));
        }
    }
}