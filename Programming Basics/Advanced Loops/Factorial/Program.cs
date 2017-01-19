using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            do
            {
                num *= n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(num);
        }
    }
}
