using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars++;
            for (int i = 0; i < (n + 1); i++)
            {
                var padding = (n - stars) / 2;
                if (padding < 0)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    return;
                }
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', padding));
                Console.WriteLine();
                stars = stars + 2;
            }
        }
    }
}
