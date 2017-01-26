using System;
using System.Linq;

namespace ExtractMiddle
{
    class Middle
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (array.Length == 1)
            {
                Console.WriteLine("{ " + $"{String.Join(", ", array)}" + " }");
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{ " + $"{array[array.Length/2 -1]}, {array[array.Length / 2]}" + " }");
            }
            else
            {
                Console.WriteLine("{ " + $"{array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]}" + " }");
            }
        }
    }
}