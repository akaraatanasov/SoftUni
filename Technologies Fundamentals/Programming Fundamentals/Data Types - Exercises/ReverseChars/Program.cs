using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char let1 = char.Parse(Console.ReadLine());
            char let2 = char.Parse(Console.ReadLine());
            char let3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{let3}{let2}{let1}");
        }
    }
}