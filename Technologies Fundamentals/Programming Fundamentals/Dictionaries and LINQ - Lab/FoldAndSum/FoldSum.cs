using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    public class FoldSum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            var leftFold = input.Take(k).Reverse().ToArray();
            var rightFold = input.Reverse().Take(k).ToArray();
            var topRow = leftFold.Concat(rightFold).ToArray();
            var bottomRow = input.Skip(k).Take(2 * k).ToArray();
            var sum = topRow.Select((x, index) => x + bottomRow[index]);

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}