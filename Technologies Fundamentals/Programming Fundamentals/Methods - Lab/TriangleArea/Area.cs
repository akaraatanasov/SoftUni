using System;

namespace TriangleArea
{
    class Area
    {
        public static double AreaOfTriangle(double width, double height)
        {
            return width * height / 2;
        }

        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfTriangle(a, h));
        }
    }
}