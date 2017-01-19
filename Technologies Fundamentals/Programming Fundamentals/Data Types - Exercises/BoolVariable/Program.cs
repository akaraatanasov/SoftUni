using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(Convert.ToBoolean(input))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}