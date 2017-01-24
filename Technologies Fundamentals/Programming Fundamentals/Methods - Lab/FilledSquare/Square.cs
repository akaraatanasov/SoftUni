using System;

namespace FilledSquare
{
    class Square
    {
        public static void PrintHeaderAndFooter(int size)
        {
            Console.WriteLine(new string('-', 2*size));
        }

        public static void PrintMiddle(int size)
        {
            Console.Write('-');
            for (int i = 1; i < size; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderAndFooter(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddle(n);
            }
            PrintHeaderAndFooter(n);
        }
    }
}