using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2Kplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            while (x <= n)
            {
                Console.WriteLine(x);
                x = x * 2 + 1;
            }
        }
    }
}
