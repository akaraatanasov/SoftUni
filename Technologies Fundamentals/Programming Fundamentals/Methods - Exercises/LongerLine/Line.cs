using System;

namespace LongerLine
{
    class Line
    {
        public static void ClosestToCenter(int x1, int y1, int x2, int y2)
        {
            double minDiag = Math.Sqrt(x1 * x1 + y1 * y1);
            if (minDiag < Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.Write($"({x1}, {y1})");
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        public static void LongestLine(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            double distFirst = Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2));
            double distSecond = Math.Sqrt(Math.Abs(x3 - x4) * Math.Abs(x3 - x4) + Math.Abs(y3 - y4) * Math.Abs(y3 - y4));
            if (distFirst > distSecond)
            {
                ClosestToCenter(x1, y1, x2, y2);
            }
            else
            {
                ClosestToCenter(x3, y3, x4, y4);
            }
        }

        public static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}