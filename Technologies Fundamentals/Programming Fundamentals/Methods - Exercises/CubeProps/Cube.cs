using System;

namespace CubeProps
{
    class Cube
    {
        public static double CubeProperties(double size, string command)
        {
            double result = 0;

            if (command == "face")
            {
                result = Math.Sqrt(2 * size * size);
            }
            else if (command == "space")
            {
                result = Math.Sqrt(3 * size * size);
            }
            else if (command == "volume")
            {
                result = size * size * size;
            }
            else if (command == "area")
            {
                result = 6 * size * size;
            }

            return result;
        }

        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            Console.WriteLine($"{CubeProperties(side, property):f2}");
        }
    }
}