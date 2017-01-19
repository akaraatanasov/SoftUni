using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = ((48 - h) * (3.0 / 4)) + h + (p * (2.0 / 3));

            if (type == "leap")
            {
                result = result * 0.15 + result;
                Console.WriteLine(Math.Truncate(result));
            }
            else if (type == "normal")
            {
                Console.WriteLine(Math.Truncate(result));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
