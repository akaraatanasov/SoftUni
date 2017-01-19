using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type side A of the rectangle:");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Type side B of the rectangle:");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is:");
            Console.WriteLine(a * b);
        }
    }
}
