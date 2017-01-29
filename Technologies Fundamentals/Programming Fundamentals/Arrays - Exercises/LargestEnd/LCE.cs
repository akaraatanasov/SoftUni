using System;
using System.Linq;

namespace LargestEnd
{
    class LCE
    {
        public static void Main()
        {
            string[] word1 = Console.ReadLine().Split(' ').ToArray();
            string[] word2 = Console.ReadLine().Split(' ').ToArray();

            int index = 0, leftRight = 0, rightLeft = 0;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i].Equals(word2[i]))
                {
                    leftRight++;
                }
            }

            int wordDiff = Math.Max(word1.Length, word2.Length) - Math.Min(word1.Length, word2.Length);

            for (int i = Math.Max(word1.Length, word2.Length) - 1; i >= wordDiff; i--)
            {
                if (word1.Length == Math.Max(word1.Length, word2.Length))
                {
                    if (word1[i].Equals(word2[i - wordDiff]))
                    {
                        rightLeft++;
                    }
                }
                else
                {
                    if (word2[i].Equals(word1[i - wordDiff]))
                    {
                        rightLeft++;
                    }
                }
            }

            if (leftRight > 0 || rightLeft > 0)
            {
                Console.WriteLine(Math.Max(leftRight,rightLeft));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}