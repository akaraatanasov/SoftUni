using System;

namespace Eratosthenes
{
    class Sieve
    {
        public static void Main()
        {
            int toN = int.Parse(Console.ReadLine());
            bool[] primes = new bool[toN + 1];

            for (int num = 0; num <= toN; num++)
            {
                primes[num] = true;
            }
            primes[0] = primes[1] = false;

            for (int num = 1; num < primes.Length; num++)
            {
                if (primes[num] == true)
                {
                    for (int multiplier = 2; multiplier * num <= toN; multiplier++)
                    {
                        primes[multiplier * num] = false;
                    }
                }
            }

            for (int num = 2; num <= toN; num++)
            {
                if (primes[num] == true)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}