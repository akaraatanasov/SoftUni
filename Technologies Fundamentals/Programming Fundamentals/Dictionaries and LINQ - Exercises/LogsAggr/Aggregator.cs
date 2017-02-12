using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggr
{
    public class Aggregator
    {
        public static void Main()
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            var UserAndIPduration = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numOfInputs; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!UserAndIPduration.ContainsKey(input[1]))
                {
                    UserAndIPduration.Add(input[1], new Dictionary<string, int>());
                    UserAndIPduration[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else if (!UserAndIPduration[input[1]].ContainsKey(input[0]))
                {
                    UserAndIPduration[input[1]].Add(input[0], int.Parse(input[2]));
                }
                else
                {
                    UserAndIPduration[input[1]][input[0]] += int.Parse(input[2]);
                }
            }

            foreach (var user in UserAndIPduration.OrderBy(x => x.Key))
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} ");

                var IPs = new List<string>();
                foreach (var ip in user.Value.OrderBy(x => x.Key))
                {
                    IPs.Add(ip.Key);
                }

                Console.WriteLine("[{0}]", String.Join(", ", IPs));
            }

        }
    }
}