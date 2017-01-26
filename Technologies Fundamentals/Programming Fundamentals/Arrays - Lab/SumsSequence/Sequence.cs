using System;

namespace SumsSequence
{
    class Sequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var sequence = new int[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                int result = 0;
                for (int j = i-1; j >= 0 && j >= i-k; j--)
                {
                    result += sequence[j];
                }
                sequence[i] = result;
            }
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}