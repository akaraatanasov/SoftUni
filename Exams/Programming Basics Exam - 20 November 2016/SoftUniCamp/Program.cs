using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int numberOfGroups = int.Parse(Console.ReadLine());
            int sumOfAll = 0;
            for (int i = 0; i < numberOfGroups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumOfAll += people;
                if (people <= 5)
                {
                    p1 += people;
                }
                else if (people > 5 && people <= 12)
                {
                    p2 += people;
                }
                else if (people > 12 && people <= 25)
                {
                    p3 += people;
                }
                else if (people > 25 && people <= 40)
                {
                    p4 += people;
                }
                else if (people > 40)
                {
                    p5 += people;
                }
            }
            Console.WriteLine("{0:0.00}%", (p1 / sumOfAll) * 100);
            Console.WriteLine("{0:0.00}%", (p2 / sumOfAll) * 100);
            Console.WriteLine("{0:0.00}%", (p3 / sumOfAll) * 100);
            Console.WriteLine("{0:0.00}%", (p4 / sumOfAll) * 100);
            Console.WriteLine("{0:0.00}%", (p5 / sumOfAll) * 100);
        }
    }
}
