using System;
using System.Linq;

namespace EqualSums
{
    class Equal
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                sumLeft = 0;
                for (int iLeft = i; iLeft > 0; iLeft--)
                {
                    if (iLeft > 0)
                    {
                        sumLeft += array[iLeft - 1];
                    }
                }

                sumRight = 0;
                for (int iRight = i; iRight < array.Length; iRight++)
                {
                    if (iRight < array.Length - 1)
                    {
                        sumRight += array[iRight + 1];
                    }
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");
        }
    }
}