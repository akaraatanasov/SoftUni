using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool flag = false;
            for (int number = 1; number <= limit; number++)
            {
                num = number;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                flag = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {flag}");
                sum = 0;
                number = num;
            }
        }
    }
}
