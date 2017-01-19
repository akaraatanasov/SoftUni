using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            for (var i = 0; i <= n; i++)
            {
                Console.WriteLine(x);
                x *= 2;
            }
        }
    }
}
