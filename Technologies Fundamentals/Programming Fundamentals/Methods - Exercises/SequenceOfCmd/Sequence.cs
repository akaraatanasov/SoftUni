using System;
using System.Linq;

namespace SequenceOfCmd
{
    class Sequence
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] line = command.Split(ArgumentsDelimiter).ToArray();
                int[] args = new int[2];

                if (line[0].Equals("add") || line[0].Equals("subtract") || line[0].Equals("multiply"))
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);
                    PerformAction(array, line[0], args);
                    Console.WriteLine(String.Join(" ", array));
                }
                else
                {
                    PerformAction(array, line[0]);
                }

                command = Console.ReadLine();
            }
        }

        public static void PerformAction(int[] array, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
        }

        public static void PerformAction(int[] array, string action)
        {
            if (action.Equals("lshift"))
            {
                ArrayShiftLeft(array);
            }
            if (action.Equals("rshift"))
            {
                ArrayShiftRight(array);
            }
        }

        private static void ArrayShiftRight(int[] array)
        {
            int[] rotatedArray = new int[array.Length];

            rotatedArray[0] = array[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                rotatedArray[i] = array[i - 1];
            }

            Console.WriteLine(String.Join(" ", rotatedArray));
        }

        private static void ArrayShiftLeft(int[] array)
        {
            int[] rotatedArray = new int[array.Length];

            rotatedArray[array.Length - 1] = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                rotatedArray[i] = array[i+1];
            }

            Console.WriteLine(String.Join(" ", rotatedArray));
        }

    }
}