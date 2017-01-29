using System;
using System.Linq;

namespace RotateSum
{
    class Rotate
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            int[] summedArray = new int[array.Length];

            while (numOfRotations > 0)
            {
                int[] rotatedArray = new int[array.Length];

                rotatedArray[0] = array[array.Length - 1];
                for (int i = 1; i < array.Length; i++)
                {
                    rotatedArray[i] = array[i - 1];
                }
                array = rotatedArray;

                for (int i = 0; i < array.Length; i++)
                {
                    summedArray[i] += rotatedArray[i];
                }
                numOfRotations--;
            }

            Console.WriteLine(String.Join(" ",summedArray));
        }
    }
}