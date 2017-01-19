using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            dateOfBirth = dateOfBirth.AddDays(999);
            Console.WriteLine(dateOfBirth.ToString("dd-MM-yyyy"));
        }
    }
}
