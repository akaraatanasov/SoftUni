using System;

namespace MasterNum
{
    class Master
    {
        public static bool SumOfDigits(int num)
        {
            int sum = 0;
            foreach(var symbol in num.ToString())
            {
                var digit = symbol - '0';
                sum += digit;
            }
            return (sum % 7 == 0);
        }

        public static bool IsPalindrome(int num)
        {

            string reversedString = "";
            for (int i = num.ToString().Length - 1; i >= 0; i--)
            {
                reversedString += num.ToString()[i];
            }
            return num.ToString() == reversedString;
        }

        public static bool ContainsEvenDigit(int num)
        {
            foreach (var symbol in num.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}