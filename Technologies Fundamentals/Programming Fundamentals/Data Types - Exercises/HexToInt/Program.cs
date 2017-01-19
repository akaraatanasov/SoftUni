using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(num1, 16));
            Console.WriteLine(Convert.ToInt32(num2, 16));
            Console.WriteLine(Convert.ToInt32(num3, 16));
        }
    }
}