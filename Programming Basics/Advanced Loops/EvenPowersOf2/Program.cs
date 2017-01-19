using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            for (var i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x *= 2;
            }
        }
    }
}
