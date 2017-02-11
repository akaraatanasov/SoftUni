using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerTask
{
    public class Task
    {
        public static void Main()
        {
            var resource = String.Empty;
            int quantity = 0;

            var minerTask = new Dictionary<string, int>();

            while (true)
            {
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());

                if (minerTask.ContainsKey(resource))
                {
                    minerTask[resource] += quantity;
                }
                else
                {
                    minerTask[resource] = quantity;
                }
            }

            foreach (var pair in minerTask)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}