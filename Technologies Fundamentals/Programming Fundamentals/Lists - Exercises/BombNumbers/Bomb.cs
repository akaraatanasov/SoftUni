using System;
using System.Linq;

namespace BombNumbers
{
    class Bomb
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    int leftindex = Math.Max(i - bomb[1], 0);
                    int rightindex = Math.Min(i + bomb[1], numbers.Count - 1);

                    numbers.RemoveRange(i, rightindex - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftindex, i - leftindex);
                    i = 0;

                }

            }

            Console.WriteLine(numbers.Sum());

        }
    }
}