using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Groups
{
    public class StudentGroups
    {
        public static void Main()
        {
            var allTowns = ReadTownsAndStudents();
            var allGroups = DistributeStudents(allTowns);
            PrintAllGroups(allTowns, allGroups);
        }

        public static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            var input = Console.ReadLine();
            while (!input.Equals("End"))
            {
                if (input.Contains("=>"))
                {
                    var townInput = input.Split(new[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var seats = townInput[1].Trim().Split().ToArray();

                    var town = new Town()
                    {
                        Name = townInput[0],
                        SeatsCount = int.Parse(seats[0]),
                        Students = new List<Student>()
                    };

                    towns.Add(town);
                }
                else
                {
                    var studentInput = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var student = new Student
                    {
                        Name = studentInput[0].Trim(),
                        Email = studentInput[1].Trim(),
                        RegistrationDate = DateTime.ParseExact(studentInput[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };

                    towns[towns.Count - 1].Students.Add(student);
                }

                input = Console.ReadLine();
            }

            return towns;
        }

        public static List<Group> DistributeStudents(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns.OrderBy(t => t.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        public static void PrintAllGroups(List<Town> towns, List<Group> groups)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups.OrderBy(t => t.Town.Name))
            {
                Console.Write($"{group.Town.Name}=> ");

                var emails = new List<string>();
                foreach (var student in group.Students)
                {
                    emails.Add(student.Email);
                }
                Console.WriteLine(String.Join(", ", emails));
            }
        }
    }
}