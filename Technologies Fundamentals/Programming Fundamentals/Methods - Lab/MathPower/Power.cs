using System;

namespace MathPower
{
    class Power
    {
        public static double PowerOfNum(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerOfNum(num, pow));
        }
    }
}