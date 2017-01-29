using System;
using System.Linq;

namespace MaxSequence
{
    class Sequence
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = 0;
            int seqStart = 0;
            int bestLen = 1;
            int seqLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    seqLen++;
                    if (bestLen < seqLen)
                    {
                        bestLen = seqLen;
                        bestStart = seqStart;
                    }
                }
                else
                {
                    if (bestLen < seqLen)
                    {
                        bestLen = seqLen;
                        bestStart = seqStart;
                    }
                    seqStart = i;
                    seqLen = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}