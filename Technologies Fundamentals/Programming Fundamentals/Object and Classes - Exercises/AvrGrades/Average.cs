using System;
using System.Collections.Generic;
using System.Linq;

namespace AvrGrades
{
    public class Average
    {
        public static void Main()
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            var students = new List<Students>();

            for (int i = 0; i < numOfStudents; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                double[] grades = new double[input.Length - 1];
                for (int j = 1; j < input.Length; j++)
                {
                    grades[j - 1] = double.Parse(input[j]);
                }

                var student = new Students
                {
                    Name = input[0],
                    Grades = grades
                };

                students.Add(student);
            }

            var results = students.Where(st => st.AverageGrade >= 5).OrderByDescending(st => st.AverageGrade);

            foreach (var result in results.OrderBy(st => st.Name))
            {
                Console.WriteLine($"{result.Name} -> {result.AverageGrade:f2}");
            }

        }
    }
}