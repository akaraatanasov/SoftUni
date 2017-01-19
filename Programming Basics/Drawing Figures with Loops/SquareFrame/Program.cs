using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
            for (int r = 0; r < n - 2; r++)
            {
                Console.Write("|");
                for (int c = 0; c < n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
        }
    }
}
