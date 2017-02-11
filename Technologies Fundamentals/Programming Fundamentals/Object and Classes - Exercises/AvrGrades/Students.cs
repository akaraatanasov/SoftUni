using System.Linq;

namespace AvrGrades
{
    public class Students
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
}