using System;
using System.Linq;

namespace CommandInterpreter
{
    public class Interpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            var input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                var command = input.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "reverse":
                        int startReverse = int.Parse(command[2]);
                        int countReverse = int.Parse(command[4]);

                        if (startReverse < 0 || startReverse >= array.Count() || startReverse + countReverse >= array.Count() || countReverse < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            Reverse(array, startReverse, countReverse);
                        }

                        break;
                    case "sort":
                        int startSort = int.Parse(command[2]);
                        int countSort = int.Parse(command[4]);

                        if (startSort < 0 || startSort >= array.Count() || startSort + countSort >= array.Count() || countSort < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            Sort(array, startSort, countSort);
                        }

                        break;
                    case "rollLeft":
                        int timesLeft = int.Parse(command[1]);

                        if (timesLeft <= 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            RollLeft(array, timesLeft);
                        }

                        break;
                    case "rollRight":
                        int timesRight = int.Parse(command[1]);

                        if (timesRight <= 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            RollRight(array, timesRight);
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input parameters.");
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", String.Join(", ", array));
        }

        public static void Reverse(string[] arr, int start, int count)
        {
            string[] tempArray = new string[count];

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                tempArray[j] = arr[i];
            }

            string[] reversedArray = tempArray.Reverse().ToArray();

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                arr[i] = reversedArray[j];
            }
        }

        public static void Sort(string[] arr, int start, int count)
        {
            string[] tempArray = new string[count];

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                tempArray[j] = arr[i];
            }

            Array.Sort(tempArray);

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                arr[i] = tempArray[j];
            }

        }

        public static void RollLeft(string[] arr, int times)
        {
            for (int j = 0; j < times; j++)
            {
                string[] rotatedArray = new string[arr.Length];

                rotatedArray[arr.Length - 1] = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    rotatedArray[i] = arr[i + 1];
                }

                for (int i = 0; i < rotatedArray.Length; i++)
                {
                    arr[i] = rotatedArray[i];
                }
            }

        }

        public static void RollRight(string[] arr, int times)
        {
            for (int j = 0; j < times; j++)
            {
                string[] rotatedArray = new string[arr.Length];

                rotatedArray[0] = arr[arr.Length - 1];
                for (int i = 1; i < arr.Length; i++)
                {
                    rotatedArray[i] = arr[i - 1];
                }

                for (int i = 0; i < rotatedArray.Length; i++)
                {
                    arr[i] = rotatedArray[i];
                }
            }

        }

    }
}