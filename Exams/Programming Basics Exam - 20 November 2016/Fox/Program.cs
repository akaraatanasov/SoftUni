using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int beg = 1, end = 1, mid = (2 * n + 3) - (beg + end + 2);

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', beg) + '\\');
                Console.Write(new string('-', ((2 * n + 3) - (beg + end + 2))));
                Console.WriteLine('/' + new string('*', end));
                beg++;
                end++;
            }
            beg = n / 2;
            end = n / 2;
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write('|' + new string('*', beg) + '\\');
                Console.Write(new string('*', ((2 * n + 3) - (beg + end + 4))));
                Console.WriteLine('/' + new string('*', end) + '|');
                beg++;
                end++;
            }
            beg = 1;
            end = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', beg) + '\\');
                Console.Write(new string('*', ((2 * n + 3) - (beg + end + 2))));
                Console.WriteLine('/' + new string('-', end));
                beg++;
                end++;
            }
        }
    }
}
