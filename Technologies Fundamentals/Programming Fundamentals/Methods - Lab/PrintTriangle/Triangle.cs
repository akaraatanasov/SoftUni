using System;

namespace PrintTriangle
{
    class Triangle
    {
        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                PrintLine(1, i);
            }
            for (int i = size-1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}