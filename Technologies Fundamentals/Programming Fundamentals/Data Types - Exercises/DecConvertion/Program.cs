using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            string hex = Convert.ToString(num, 16);
            hex = hex.ToUpper();
            Console.WriteLine(binary);
            Console.WriteLine(hex);
        }
    }
}
