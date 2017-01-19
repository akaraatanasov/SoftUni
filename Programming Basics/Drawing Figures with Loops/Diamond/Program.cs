using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars++;
            int leftRight = (n - 1) / 2;
            int mid = 0;
            Console.Write(new string('-', leftRight));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', leftRight));
            for (int i = 1; i < (n / 2 + 1); i++)
            {
                leftRight--;
                if (leftRight >= 0)
                {
                    mid = n - (2 * leftRight) - 2;
                }
                else
                {
                    leftRight++;
                    for (int j = (n - (n / 2 + 1)); j > 0; j--)
                    {
                        leftRight++;
                        mid = n - (2 * leftRight) - 2;
                        Console.Write(new string('-', leftRight));
                        Console.Write("*");
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        Console.WriteLine(new string('-', leftRight));
                    }
                    return;
                }
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                Console.Write(new string('-', mid));
                Console.Write("*");
                Console.WriteLine(new string('-', leftRight));
            }
            for (int j = (n - (n / 2 + 1)); j > 0; j--)
            {
                leftRight++;
                mid = n - (2 * leftRight) - 2;
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                if (mid <= 0)
                {
                    Console.WriteLine(new string('-', leftRight));
                    return;
                }
                Console.Write(new string('-', mid));
                Console.Write("*");
                Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}
