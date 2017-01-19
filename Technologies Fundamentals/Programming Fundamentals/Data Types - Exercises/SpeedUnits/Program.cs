using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int allSeconds = seconds + minutes * 60 + hours * 3600;
            double metersPS = meters / allSeconds;
            double kilometersPH = metersPS * 3.6;
            double milesPH = kilometersPH * 0.62175;
            Console.WriteLine($"{metersPS:f6}");
            Console.WriteLine($"{kilometersPH:f6}");
            Console.WriteLine($"{milesPH:f6}");
        }
    }
}