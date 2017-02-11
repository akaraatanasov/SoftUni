using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGrp
{
    public class Mentor
    {
        public static void Main()
        {
            var allStudents = new SortedDictionary<string, Student>();

            var dateInput = Console.ReadLine();
            while (!dateInput.Equals("end of dates"))
            {
                var input = dateInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                bool studentExist = false;

                foreach (var person in allStudents)
                {
                    if (person.Key == input[0])
                    {
                        studentExist = true;

                        for (int i = 1; i < input.Length; i++)
                        {
                            var date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            person.Value.DatesAttended.Add(date);
                        }
                    }
                }

                if (!studentExist)
                {
                    var student = new Student()
                    {
                        DatesAttended = new List<DateTime>(),
                        Comments = new List<string>()
                    };

                    for (int i = 1; i < input.Length; i++)
                    {
                        var date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        student.DatesAttended.Add(date);
                    }

                    allStudents[input[0]] = student;
                }

                dateInput = Console.ReadLine();
            }

            var commentInput = Console.ReadLine();
            while (!commentInput.Equals("end of comments"))
            {
                var input = commentInput.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                bool studentExist = false;

                foreach (var person in allStudents)
                {
                    if (person.Key == input[0])
                    {
                        studentExist = true;
                        person.Value.Comments.Add(input[1]);
                    }
                }

                if (!studentExist)
                {
                    if (allStudents.ContainsKey(input[0]))
                    {
                        var student = new Student
                        {
                            Comments = new List<string>()
                        };

                        student.Comments.Add(input[1]);

                        allStudents[input[0]] = student;
                    }
                }

                commentInput = Console.ReadLine();
            }

            foreach (var entry in allStudents)
            {
                Console.WriteLine($"{entry.Key}");
                Console.WriteLine("Comments:");

                if (entry.Value.Comments != null)
                {
                    foreach (var comment in entry.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in entry.Value.DatesAttended.OrderBy(d => d))
                {
                    Console.WriteLine("-- " + date.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}