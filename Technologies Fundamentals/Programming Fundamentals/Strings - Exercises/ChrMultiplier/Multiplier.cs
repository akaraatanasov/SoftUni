using System;
using System.Linq;

namespace ChrMultiplier
{
    public class Multiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();

            Console.WriteLine(Sum(firstWord,secondWord));

        }

        public static int Sum(char[] first, char[] second)
        {
            int sum = 0;

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else
            {
                for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
                {
                    sum += first[i] * second[i];
                }

                for (int i = Math.Min(first.Length, second.Length); i < Math.Max(first.Length, second.Length); i++)
                {
                    if (Math.Max(first.Length, second.Length) == first.Length)
                    {
                        sum += first[i];
                    }
                    else
                    {
                        sum += second[i];
                    }
                }
            }

            return sum;
        }
    }
}