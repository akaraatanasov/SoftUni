using System;
using System.Linq;
using System.Numerics;

namespace From10toBaseN
{
    public class BaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            int baseNumber = int.Parse(input[0]);
            BigInteger number = int.Parse(input[1]);

            if (baseNumber >= 2 && baseNumber <= 10)
            {
                Console.WriteLine(Base10toBaseN(baseNumber, number));
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }

        public static string Base10toBaseN(int numberBase, BigInteger num)
        {
            string result = string.Empty;
            BigInteger remaining = 0;

            while (num > 0)
            {
                remaining = num % numberBase;
                num /= numberBase;

                result = remaining.ToString() + result;
            }

            return result;
        }
    }
}