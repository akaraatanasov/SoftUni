using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    num++;
                    Console.Write(num + " ");
                    if (num == n)
                        break;
                }
                Console.WriteLine();
                if (num == n)
                    break;
            }
        }
    }
}
