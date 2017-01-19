using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double meters = 0;
            double result = 0;
            if (from == "mm")
            {
                meters = number / 1000;
            }
            else if (from == "cm")
            {
                meters = number / 100;
            }
            else if (from == "mi")
            {
                meters = number * 1609.344;
            }
            else if (from == "in")
            {
                meters = number / 0.0254;
            }
            else if (from == "km")
            {
                meters = number * 1000;
            }
            else if (from == "ft")
            {
                meters = number / 0.3048;
            }
            else if (from == "yd")
            {
                meters = number / 0.9144;
            }
            else if (from == "m")
            {
                meters = number;
            }

            if (to == "mm")
            {
                result = meters * 1000;
            }
            else if (to == "cm")
            {
                result = meters * 100;
            }
            else if (to == "mi")
            {
                result = meters * 0.000621371192;
            }
            else if (to == "in")
            {
                result = meters * 39.3700787;
            }
            else if (to == "km")
            {
                result = meters * 0.001;
            }
            else if (to == "ft")
            {
                result = meters * 3.2808399;
            }
            else if (to == "yd")
            {
                result = meters * 1.0936133;
            }
            else if (to == "m")
            {
                result = meters;
            }

            Console.WriteLine(result + " " + to);
        }
    }
}
