using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrManipulator
{
    public class Manipulator
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (!command.Equals("print"))
            {
                var line = command.Split(ArgumentsDelimiter).ToList();

                switch (line[0])
                {
                    case "add":
                        list.Insert(int.Parse(line[1]), int.Parse(line[2]));
                        break;

                    case "addMany":
                        var newList = new List<int>();

                        for (int i = 2; i < line.Count; i++)
                        {
                            newList.Add(int.Parse(line[i]));
                        }

                        list.InsertRange(int.Parse(line[1]), newList);
                        break;

                    case "contains":
                        if (list.Contains(int.Parse(line[1])))
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (int.Parse(line[1]) == list[i])
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }

                        break;

                    case "remove":
                        list.RemoveAt(int.Parse(line[1]));
                        break;

                    case "shift":
                        for (int j = 0; j < int.Parse(line[1]); j++)
                        {
                            var shiftedList = new List<int>();

                            for (int i = 0; i < list.Count - 1; i++)
                            {
                                shiftedList.Add(list[i + 1]);
                            }
                            shiftedList.Add(list[0]);

                            list.Clear();
                            for (int i = 0; i < shiftedList.Count; i++)
                            {
                                list.Add(shiftedList[i]);
                            }
                        }

                        break;

                    case "sumPairs":
                        var summedList = new List<int>();
                        if (list.Count % 2 == 0)
                        {
                            for (int i = 0; i < list.Count; i+=2)
                            {
                                summedList.Add(list[i] + list[i + 1]);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < list.Count - 1; i++)
                            {
                                summedList.Add(list[i] + list[i + 1]);
                            }
                            summedList.Add(list[list.Count - 1]);
                        }

                        list.Clear();
                        list = summedList;

                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{ String.Join(", ", list)}]");
        }
    }
}