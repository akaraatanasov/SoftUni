using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            while (m != 0)
            {
                int oldM = m;
                m = n % m;
                n = oldM;
            }
            Console.WriteLine(n);
        }
    }
}
