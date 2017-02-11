using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    public class Logs
    {
        public static void Main()
        {
            var UserAndData = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine().Split(' ').ToArray();
            while(!input[0].Equals("end"))
            {
                string[] IPinfo = input[0].Split('=');
                string ip = IPinfo[1];

                string[] USRinfo = input[2].Split('=');
                string user = USRinfo[1];

                if (!UserAndData.ContainsKey(user))
                {
                    UserAndData.Add(user, new Dictionary<string, int>());
                    UserAndData[user].Add(ip, 0);
                }
                else if (!UserAndData[user].ContainsKey(ip))
                {
                    UserAndData[user].Add(ip, 0);
                }

                UserAndData[user][ip]++;

                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var outerPair in UserAndData)
            {
                Console.WriteLine($"{outerPair.Key}: ");
                Console.WriteLine("{0}.", String.Join(", ", outerPair.Value.Select(x=>$"{x.Key} => {x.Value}")));
            }
        }
    }
}