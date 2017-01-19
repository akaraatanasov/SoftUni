using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result = -1.0;


            if (type == "premiere")
            {
                result = (c * r * 12.00);
            }
            else if (type == "normal")
            {
                result = (c * r * 7.50);
            }
            else if (type == "discount")
            {
                result = (c * r * 5.00);
            }

            if (result == -1.0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
