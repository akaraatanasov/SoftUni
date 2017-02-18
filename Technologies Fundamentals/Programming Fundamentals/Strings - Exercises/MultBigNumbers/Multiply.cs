using System;
using System.Text;

namespace MultBigNumbers
{
    public class Multiply
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine();

            if (firstNum == "0" || secondNum == "0")
            {
                Console.WriteLine(0);
                return;
            }

            if (firstNum.Length < secondNum.Length)
            {
                string temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }

            int inMind = 0;
            int currentSum = 0;
            var result = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(firstNum[i].ToString()) * int.Parse(secondNum) + inMind;
                inMind = sum / 10;
                currentSum = sum % 10;
                result.Insert(0, currentSum);
                if (i == 0 && inMind!=0)
                {
                    result.Insert(0, inMind);
                }
            }

            Console.WriteLine(result);
        }
    }
}