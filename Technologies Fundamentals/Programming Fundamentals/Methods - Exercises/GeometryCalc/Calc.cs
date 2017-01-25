using System;

namespace GeometryCalc
{
    class Calc
    {
        public static double GeometryCalculator(double sizeA, double sizeB)
        {
            return sizeA * sizeB;
        }

        public static double GeometryCalculator(double sizeA)
        {
            return sizeA * sizeA;
        }

        public static void Main()
        {
            string property = Console.ReadLine();

            if (property == "triangle" || property == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                if (property == "rectangle")
                {
                    Console.WriteLine($"{GeometryCalculator(sideA, sideB):f2}");
                }
                else
                {
                    Console.WriteLine($"{GeometryCalculator(sideA, sideB) / 2:f2}");
                }
            }
            else if (property == "square" || property == "circle")
            {
                double sideA = double.Parse(Console.ReadLine());

                if (property == "square")
                {
                    Console.WriteLine($"{GeometryCalculator(sideA):f2}");
                }
                else
                {
                    Console.WriteLine($"{GeometryCalculator(sideA)*Math.PI:f2}");
                }
            }
        }
    }
}