using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int bitkaNo = 0;

            for (int i = 1; i <= p1; i++)
            {
                for (int j = 1; j <= p2; j++)
                {
                    Console.Write("({0} <-> {1}) ", i, j);
                    bitkaNo++;
                    if (bitkaNo == max)
                    {
                        return;
                    }
                }
            }
        }
    }
}
