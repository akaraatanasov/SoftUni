using System;

namespace MaxMethod
{
    class GetMax
    {
        public static int GetMaxNum(int firstNum, int secondNum)
        {
            if(firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxNum(GetMaxNum(first, second), third));
        }
    }
}