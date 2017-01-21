using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            for (int num = 0; num <= rangeEnd; num++)
            {
                bool flag = true;
                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} is prime -> {flag}");
            }
        }
    }
}