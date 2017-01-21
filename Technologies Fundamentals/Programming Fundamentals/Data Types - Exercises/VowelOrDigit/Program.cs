using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'o' || input == 'u' || input == 'e' || input == 'i')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}