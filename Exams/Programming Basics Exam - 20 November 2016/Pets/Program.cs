using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodDog = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTurtle = double.Parse(Console.ReadLine());

            double foodFD = days * foodDog;
            double foodFC = days * foodCat;
            double foodFT = days * (foodTurtle / 1000);
            double result = foodFD + foodFC + foodFT;

            if (result <= foodLeft)
            {
                Console.WriteLine("{0} kilos of food left. ", Math.Floor(foodLeft - result));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed. ", Math.Ceiling(result - foodLeft));
            }
        }
    }
}
