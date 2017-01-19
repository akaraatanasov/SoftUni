using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num;
            int sum = 0;
            do
            {
                num = n % 10;
                sum += num;
                n /= 10;
            }
            while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
