using System;
using System.Linq;

namespace FrequentNumber
{
    class Frequent
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int occurances= 0;
            int mostFrequentNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                int count = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (currentNum == array[j])
                    {
                        count++;
                    }

                }

                if (count > occurances)
                {
                    occurances = count;
                    mostFrequentNum = currentNum;
                }

            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}