using System;

namespace CondenseArray
{
    class Condense
    {
        public static void Main()
        {
            string[] arrStr = Console.ReadLine().Split();
            int[] arrayNums = new int[arrStr.Length];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(arrStr[i]);
            }

            while (arrayNums.Length > 1)
            {
                int[] condensed = new int[arrayNums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arrayNums[i] + arrayNums[i + 1];
                }
                arrayNums = condensed;
            }

            Console.WriteLine(string.Join(" ", arrayNums));
        }
    }
}