using System;
using System.Numerics;

namespace BigFact
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;
            for (int i = 2; i <= n; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
    }
}