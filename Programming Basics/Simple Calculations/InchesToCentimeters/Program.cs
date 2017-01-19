using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inches: ");
            var a = double.Parse(Console.ReadLine());
            var cm = a * 2.54;
            Console.WriteLine("Centimeters: ");
            Console.WriteLine(cm);
        }
    }
}
