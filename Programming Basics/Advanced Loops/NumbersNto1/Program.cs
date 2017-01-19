using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (var i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
