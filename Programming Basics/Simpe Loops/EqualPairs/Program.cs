using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currSum = 0;
            double prevSum = 0;
            double diff = 0;
            double maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                prevSum = currSum;
                currSum = 0;
                currSum += double.Parse(Console.ReadLine());
                currSum += double.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs(currSum - prevSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }
            if (prevSum == currSum || n == 1)
            {
                Console.WriteLine("Yes, value = " + currSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + maxDiff);
            }
        }
    }
}
