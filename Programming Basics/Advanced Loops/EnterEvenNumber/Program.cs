using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + n);
                        break;
                    }
                    else
                    {

                        Console.WriteLine("The number is not even.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
