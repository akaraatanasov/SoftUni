using System;

namespace Fibonacci
{
    class Fibonacci
    {
        public static int FibonacciNums(int n)
        {
            int first = 0;
            int second = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = first;
                first = second;
                second += temp;
            }
            return second;
        }

        public static void Main()
        {
            int finalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNums(finalNumber));
        }
    }
}