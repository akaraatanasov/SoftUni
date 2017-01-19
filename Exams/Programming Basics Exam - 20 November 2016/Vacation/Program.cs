using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int old = int.Parse(Console.ReadLine());
            int young = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double transportCosts, hotelCosts = (nights * 82.99), Comission, result;

            if (transport == "train")
            {
                if (old + young < 50)
                {
                    transportCosts = ((old * 24.99) + (young * 14.99)) * 2;
                    Comission = (transportCosts + hotelCosts) * 0.1;
                    result = transportCosts + hotelCosts + Comission;
                    Console.WriteLine("{0:0.00}", result);
                }
                else if (old + young >= 50)
                {
                    transportCosts = ((old * 24.99) + (young * 14.99));
                    Comission = (transportCosts + hotelCosts) * 0.1;
                    result = transportCosts + hotelCosts + Comission;
                    Console.WriteLine("{0:0.00}", result);
                }

            }
            else if (transport == "bus")
            {
                transportCosts = ((old * 32.50) + (young * 28.50)) * 2;
                Comission = (transportCosts + hotelCosts) * 0.1;
                result = transportCosts + hotelCosts + Comission;
                Console.WriteLine("{0:0.00}", result);
            }
            else if (transport == "boat")
            {
                transportCosts = ((old * 42.99) + (young * 39.99)) * 2;
                Comission = (transportCosts + hotelCosts) * 0.1;
                result = transportCosts + hotelCosts + Comission;
                Console.WriteLine("{0:0.00}", result);
            }
            else if (transport == "airplane")
            {
                transportCosts = ((old * 70) + (young * 50)) * 2;
                Comission = (transportCosts + hotelCosts) * 0.1;
                result = transportCosts + hotelCosts + Comission;
                Console.WriteLine("{0:0.00}", result);
            }
        }
    }
}
