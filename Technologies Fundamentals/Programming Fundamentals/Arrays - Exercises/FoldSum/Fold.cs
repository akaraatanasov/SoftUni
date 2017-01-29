using System;
using System.Linq;

namespace FoldSum
{
    class Fold
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstNlastRev = new int[array.Length / 2];
            int[] summedArray = new int[array.Length / 2];
            int index = 0;

            for (int i = array.Length/4 - 1; i >= 0; i--)
            {
                firstNlastRev[index] = array[i];
                index++;
            }

            for (int i = array.Length - 1; i > array.Length - array.Length/4 - 1 ; i--)
            {
                firstNlastRev[index] = array[i];
                index++;
            }

            index = 0;
            
            for (int i = array.Length/4; i < array.Length - array.Length / 4; i++)
            {
                summedArray[index] = array[i];
                index++;
            }

            for (int i = 0; i < array.Length/2; i++)
            {
                summedArray[i] += firstNlastRev[i];
            }

            Console.WriteLine(String.Join(" ", summedArray));
        }
    }
}