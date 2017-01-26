using System;

namespace TripleSum
{
    class Triples
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] array = input.Split(' ');
            int[] arrayNums = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayNums[i] = int.Parse(array[i]);
            }

            int counter = 0;

            for (int i = 0; i < arrayNums.Length; i++)
            {
                for (int j = i+1; j < arrayNums.Length; j++)
                {
                    for (int k = 0; k < arrayNums.Length; k++)
                    {
                        if (arrayNums[i]+arrayNums[j] == arrayNums[k])
                        {
                            counter++;
                            Console.WriteLine($"{arrayNums[i]} + {arrayNums[j]} == {arrayNums[k]}");
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}