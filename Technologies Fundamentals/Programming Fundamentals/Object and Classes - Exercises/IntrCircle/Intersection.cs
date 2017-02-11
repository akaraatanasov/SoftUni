using System;
using System.Linq;

namespace IntrCircle
{
    public class Intersection
    {
        public static void Main()
        {
            var firstCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Circle first = new Circle
            {
                Center = new Point { X = firstCircle[0], Y = firstCircle[1] },
                Radius = firstCircle[2]
            };

            Circle second = new Circle
            {
                Center = new Point { X = secondCircle[0], Y = secondCircle[1] },
                Radius = secondCircle[2]
            };

            if (Intersect(first, second))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static bool Intersect(Circle one, Circle two)
        {
            if (CalculateDistance(one.Center, two.Center) <= one.Radius + two.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
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