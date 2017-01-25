using System;

namespace EvenToOdds
{
    class Multiplication
    {
        public static int getSum(int number, int condition)
        {
            int result = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == condition)
                {
                    result += digit;
                }
            }

            return result;
        }

        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(getSum(num,0)*getSum(num,1));
        }
    }
}