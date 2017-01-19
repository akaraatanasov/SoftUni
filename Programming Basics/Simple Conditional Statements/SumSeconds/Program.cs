using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRunner = int.Parse(Console.ReadLine());
            int secondRunner = int.Parse(Console.ReadLine());
            int thirdRunner = int.Parse(Console.ReadLine());

            int totalSeconds = firstRunner + secondRunner + thirdRunner;

            int minutes = 0;

            if (totalSeconds < 60) // 0 minutes
            {

            }

            else if (totalSeconds < 120) // 1 minute
            {
                totalSeconds -= 60;
                minutes += 1;
            }

            else if (totalSeconds < 180) // 2 minutes
            {
                totalSeconds -= 120;
                minutes += 2;
            }
            if (totalSeconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, totalSeconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, totalSeconds);
            }
        }
    }
}
