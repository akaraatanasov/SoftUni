using System;

namespace PrimeChecker
{
    class Prime
    {
        public static bool ifPrime(long num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(ifPrime(number));
        }
    }
}
