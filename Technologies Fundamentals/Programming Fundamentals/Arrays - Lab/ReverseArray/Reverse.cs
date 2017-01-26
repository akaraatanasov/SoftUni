using System;

namespace ReverseArray
{
    class Reverse
    {
        public static void Main()
        {
            int numOfElements = int.Parse(Console.ReadLine());

            var array = new int[numOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var reverseArray = new int[numOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - i - 1];
            }

            string result = String.Join(" ", reverseArray);
            Console.WriteLine(result);
        }
    }
}