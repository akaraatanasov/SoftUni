using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSeqOfEqualElements
{
    public class Equal
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Add(int.MaxValue);
            int previous = numbers[0];
            int count = 1, bestCount = 0;
            int bestPosition = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == previous)
                {
                    count++;
                }
                else
                {
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestPosition = i - count;
                    }
                    else if (count == bestCount)
                    {
                        bestCount = count;
                    }
                    count = 1;
                }
                previous = numbers[i];
            }

            for (int i = bestPosition; i < bestPosition + bestCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}