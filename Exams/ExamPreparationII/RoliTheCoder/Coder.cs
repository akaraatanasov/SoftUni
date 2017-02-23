using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    public class Coder
    {
        public static void Main()
        {
            var IDandEventParticipants = new Dictionary<int, Dictionary<string, List<string>>>();

            var input = Console.ReadLine();
            while (!input.Equals("Time for Code"))
            {
                var parameters = input.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                int ID = int.Parse(parameters[0]);
                var eventName = parameters[1];
                var participants = parameters.Skip(2).ToArray();

                bool isValid = false;

                if (eventName[0] == '#')
                {
                    isValid = true;
                }

                if (isValid)
                {
                    var nameEvent = new string(eventName.ToCharArray().Skip(1).ToArray());

                    if (!IDandEventParticipants.ContainsKey(ID))
                    {
                        IDandEventParticipants.Add(ID, new Dictionary<string, List<string>>());                        
                        IDandEventParticipants[ID].Add(nameEvent, new List<string>());
                        foreach (var participant in participants)
                        {
                            IDandEventParticipants[ID][nameEvent].Add(participant);
                        }
                    }
                    else
                    {
                        if (IDandEventParticipants[ID].ContainsKey(nameEvent))
                        {
                            foreach (var participant in participants)
                            {
                                if (!IDandEventParticipants[ID][nameEvent].Contains(participant))
                                {
                                    IDandEventParticipants[ID][nameEvent].Add(participant);
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var results = new Dictionary<string, List<string>>();
            foreach (var EventAndParticipants in IDandEventParticipants.Values)
            {
                foreach (var nameOfEvent in EventAndParticipants)
                {
                    results.Add(nameOfEvent.Key, new List<string>());
                    foreach (var participant in nameOfEvent.Value.OrderBy(x => x))
                    {
                        results[nameOfEvent.Key].Add(participant);
                    }
                }
            }

            foreach (var Event in results.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{Event.Key} - {Event.Value.Count()}");
                foreach (var participant in Event.Value)
                {
                    Console.WriteLine($"{participant}");
                }
            }

        }
    }
}