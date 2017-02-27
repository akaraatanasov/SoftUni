using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    public class Armada
    {
        public static void Main()
        {
            var LegionActivity = new Dictionary<string, int>();
            var LegionSoldierTypeCount = new Dictionary<string, Dictionary<string, int>>();

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                int activity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);

                if (!LegionActivity.ContainsKey(legionName.Trim()))
                {
                    LegionActivity.Add(legionName.Trim(), activity);
                }
                else
                {
                    if (LegionActivity[legionName] < activity)
                    {
                        LegionActivity.Remove(legionName);
                        LegionActivity.Add(legionName, activity);
                    }
                }

                if (!LegionSoldierTypeCount.ContainsKey(legionName.Trim()))
                {
                    LegionSoldierTypeCount.Add(legionName.Trim(), new Dictionary<string, int>());
                    LegionSoldierTypeCount[legionName].Add(soldierType.Trim(), soldierCount);
                }
                else
                {
                    if (!LegionSoldierTypeCount[legionName].ContainsKey(soldierType.Trim()))
                    {
                        LegionSoldierTypeCount[legionName].Add(soldierType.Trim(), 0);
                    }

                    LegionSoldierTypeCount[legionName][soldierType] += soldierCount;

                }

            }

            string command = Console.ReadLine();
            if (command.Contains("\\"))
            {
                var commands = command.Split('\\').ToArray();
                int activity = int.Parse(commands[0]);
                string soldierType = commands[1];

                var legionsWithLesserActivity = new List<string>();

                foreach (var legion in LegionActivity)
                {
                    if (legion.Value < activity)
                    {
                        legionsWithLesserActivity.Add(legion.Key.Trim());
                    }
                }

                var results = new Dictionary<string, int>();
                if (legionsWithLesserActivity.Any())
                {
                    foreach (var legion in legionsWithLesserActivity)
                    {
                        if (LegionSoldierTypeCount[legion].ContainsKey(soldierType))
                        {
                            foreach (var soldier in LegionSoldierTypeCount[legion])
                            {
                                if (soldier.Key.Trim() == soldierType.Trim())
                                {
                                    results.Add(legion, soldier.Value);
                                }
                            }
                        }
                    }
                }

                if (results.Any())
                {
                    foreach (var result in results.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"{result.Key} -> {result.Value}");
                    }

                }
            }
            else
            {
                string soldierType = command;

                var legionsWithCurrSoldierType = new List<string>();

                foreach (var legion in LegionSoldierTypeCount.Keys)
                {
                    foreach (var soldType in LegionSoldierTypeCount[legion].Keys)
                    {
                        if (soldType == soldierType)
                        {
                            legionsWithCurrSoldierType.Add(legion);
                        }
                    }
                }

                var results = new Dictionary<string, int>();
                foreach (var legion in legionsWithCurrSoldierType)
                {
                    foreach (var item in LegionActivity)
                    {
                        if (item.Key == legion)
                        {
                            results.Add(item.Key, item.Value);
                        }
                    }
                }

                if (results.Any())
                {
                    foreach (var result in results.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"{result.Value} : {result.Key}");
                    }

                }
            }

        }
    }
}