using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            ushort age = ushort.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            int UEN = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee Number: {UEN}");
        }
    }
}