using System;

namespace SumArrays
{
    class ArraySum
    {
        public static void Main()
        {
            string inputFirst = Console.ReadLine();
            string[] firstInputArray = inputFirst.Split(' ');
            string inputSecond = Console.ReadLine();
            string[] secondInputArray = inputSecond.Split(' ');

            int[] firstArray = new int[firstInputArray.Length];
            int[] secondArray = new int[secondInputArray.Length];

            for (int i = 0; i < firstInputArray.Length; i++)
            {
                firstArray[i] = int.Parse(firstInputArray[i]);
            }

            for (int i = 0; i < secondInputArray.Length; i++)
            {
                secondArray[i] = int.Parse(secondInputArray[i]);
            }

            int[] resultArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    resultArray[i] = firstArray[i] + secondArray[i % secondArray.Length];
                }
                else
                {
                    resultArray[i] = firstArray[i % firstArray.Length] + secondArray[i];
                }
            }

            Console.WriteLine(String.Join(" ", resultArray));
        }
    }
}