using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkPj
{
    public class Project
    {
        public static void Main()
        {
            int teams = int.Parse(Console.ReadLine());

            var allTeams = new List<Team>();

            for (int i = 0; i < teams; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();

                bool teamExist = false;

                foreach (var item in allTeams)
                {
                    if (item.Name == input[1])
                    {
                        teamExist = true;
                        Console.WriteLine($"Team {item.Name} was already created!");
                    }

                    if (item.Creator == input[0])
                    {
                        teamExist = true;
                        Console.WriteLine($"{item.Creator} cannot create another team!");
                    }
                }

                if (!teamExist)
                {
                    var team = new Team
                    {
                        Creator = input[0],
                        Name = input[1],
                        Members = new List<string>()
                    };

                    allTeams.Add(team);

                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }

            var assignment = Console.ReadLine();
            while (!assignment.Equals("end of assignment"))
            {
                var input = assignment.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                bool teamExist = false;

                foreach (var item in allTeams)
                {
                    if (item.Name == input[1])
                    {
                        teamExist = true;
                        bool isInAnotherTeam = false;

                        if (item.Creator.Equals(input[0]))
                        {
                            isInAnotherTeam = true;
                            Console.WriteLine($"Member {item.Creator} cannot join team {item.Name}!");
                        }

                        foreach (var member in item.Members)
                        {
                            if (member.Equals(input[0]))
                            {
                                isInAnotherTeam = true;
                                Console.WriteLine($"Member {member} cannot join team {item.Name}!");
                            }
                        }

                        if (!isInAnotherTeam)
                        {
                            item.Members.Add(input[0]);
                        }
                    }
                }

                if (!teamExist)
                {
                    Console.WriteLine($"Team {input[1]} does not exist!");
                }

                assignment = Console.ReadLine();
            }

            var disbandedTeams = new List<string>();

            foreach (var item in allTeams.OrderBy(x => x.Name))
            {
                if (item.Members.Any())
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine($"- {item.Creator}");
                    foreach (var member in item.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
                else
                {
                    disbandedTeams.Add(item.Name);
                }
            }
            Console.WriteLine("Teams to disband:");

            if (disbandedTeams.Any())
            {
                foreach (var item in disbandedTeams)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}