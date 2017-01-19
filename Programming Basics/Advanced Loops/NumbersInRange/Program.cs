using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [0...100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.Write("Enter a number in the range [0...100]: ");
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
