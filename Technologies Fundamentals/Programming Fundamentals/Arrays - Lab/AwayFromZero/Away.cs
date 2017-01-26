using System;

namespace AwayFromZero
{
    class Away
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] array = input.Split(' ');
            double[] arrayNums = new double[array.Length];
                        
            for (int i = 0; i < array.Length; i++)
            {
                arrayNums[i] = double.Parse(array[i]);
            }

            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.WriteLine($"{arrayNums[i]} => {Math.Round(arrayNums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}