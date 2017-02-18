using System;
using System.Linq;
using System.Numerics;

namespace FromNtoBase10
{
    public class Base10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim().Split(' ').ToArray();

            int baseNumber = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();

            if (baseNumber >= 2 && baseNumber <= 10)
            {
                Console.WriteLine(BaseNtoBase10(baseNumber, number));
            }
            else
            {
                Console.WriteLine(0);
            }

        }

        public static string BaseNtoBase10(int numberBase, char[] num)
        {
            BigInteger result = 0;

            for (int n = 0, i = num.Length - 1; i >= 0; i--, n++)
            {
                BigInteger curDig = new BigInteger(char.GetNumericValue(num[n]));
                BigInteger sum = BigInteger.Multiply(curDig, BigInteger.Pow(new BigInteger(numberBase), i));
                result += sum;
            }

            return result.ToString();
        }
    }
}