using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugField = Enumerable.Repeat(0, fieldSize).ToArray();

            var bugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int size = Math.Min(fieldSize, bugIndexes.Count());
            foreach (var index in bugIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    bugField[index] = 1;
                }
            }

            string command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                var commandParameters = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int currBugIndex = int.Parse(commandParameters[0]);
                string currDirection = commandParameters[1];
                int flyLength = int.Parse(commandParameters[2]);

                if (currBugIndex >= 0 && currBugIndex < fieldSize && bugField[currBugIndex] == 1)
                {
                    bugField[currBugIndex] = 0;
                    if (currDirection.Equals("right"))
                    {
                        if (currBugIndex + flyLength >= 0 && currBugIndex + flyLength < fieldSize)
                        {
                            while (bugField[currBugIndex + flyLength] == 1 && currBugIndex + flyLength < fieldSize - 1)
                            {
                                flyLength++;
                            }
                            bugField[currBugIndex + flyLength] = 1;
                        }
                    }
                    else if (currDirection.Equals("left"))
                    {
                        if (currBugIndex - flyLength >= 0 && currBugIndex - flyLength < fieldSize)
                        {
                            while (bugField[currBugIndex - flyLength] == 1 && currBugIndex - flyLength > 0)
                            {
                                flyLength--;
                            }
                            bugField[currBugIndex - flyLength] = 1;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", bugField));

        }
    }
}