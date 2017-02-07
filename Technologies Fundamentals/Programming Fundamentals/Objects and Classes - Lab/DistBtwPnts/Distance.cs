using System;
using System.Collections.Generic;
using System.Linq;

namespace DistBtwPnts
{
    public class Distance
    {
        static void Main()
        {
            var firstInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };

            var secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };

            Console.WriteLine($"{CalculateDistance(firstPoint, secondPoint):F3}");
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double result = Math.Sqrt(a * a + b * b);
            return result;
        }
    }
}