using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string polygon = Console.ReadLine();
            polygon = polygon.ToLower();

            if (polygon == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double result = a * a;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            else if (polygon == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double result = a * h / 2;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            else if (polygon == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double result = a * a * Math.PI;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            else if (polygon == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = a * b;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            else
            { return; }
        }
    }
}
