using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestPoints
{
    public class Closest
    {
        public static void Main()
        {
            int numOfPoints = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < numOfPoints; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                Point currentPoint = new Point
                {
                    X = input[0],
                    Y = input[1]
                };

                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
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