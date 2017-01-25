using System;

namespace PrimesInRange
{
    class InRange
    {
        public static bool ifPrime(long num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
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

        public static void PrimesWithinRange(int start, int end)
        {
            int maxPrime = 0;

            for (int i = start; i <= end; i++)
            {
                if (ifPrime(i))
                {
                    if (maxPrime < i)
                    {
                        maxPrime = i;
                    }
                }
            }

            for (int i = start; i <= end; i++)
            {
                if (ifPrime(i))
                {
                    if(i == maxPrime)
                    {
                        Console.WriteLine($"{i}");
                    }
                    else
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }
        }

        public static void Main()
        {
            int begining = int.Parse(Console.ReadLine());
            int ending = int.Parse(Console.ReadLine());
            PrimesWithinRange(begining, ending);
        }
    }
}