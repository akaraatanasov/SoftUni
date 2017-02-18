using System;
using System.Text;

namespace SumBigNumbers
{
    public class Sum
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secNum = Console.ReadLine().TrimStart('0');

            int pad = Math.Max(firstNum.Length, secNum.Length);

            if (firstNum.Length != secNum.Length)
            {
                firstNum = firstNum.PadLeft(pad, '0');
                secNum = secNum.PadLeft(pad, '0');
            }

            int inMind = 0;
            int currentSum = 0;
            StringBuilder result = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(firstNum[i].ToString()) + int.Parse(secNum[i].ToString()) + inMind;
                inMind = sum / 10;
                currentSum = sum % 10;
                result.Insert(0, currentSum.ToString());
                if (i == 0 && inMind != 0)
                {
                    result.Insert(0, inMind.ToString());
                }
            }

            Console.WriteLine(result);
        }
    }
}