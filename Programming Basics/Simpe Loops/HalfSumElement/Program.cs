using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = -1000000000;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            if (sum / 2 == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs((sum - max) - max));
            }
        }
    }
}
