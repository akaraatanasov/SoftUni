using System;

namespace ClosestPoint
{
    class Closest
    {
        public static void ClosestToCenter(int x1, int y1, int x2, int y2)
        {
            double minDiag = Math.Sqrt(x1 * x1 + y1 * y1);
            if (minDiag < Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            ClosestToCenter(x1, y1, x2, y2);
        }
    }
}