using System;
using System.Globalization;

namespace SoftuniCoffeeOrders
{
    public class Orders
    {
        public static void Main()
        {
            int numOfOrders = int.Parse(Console.ReadLine());
            decimal total = 0m;

            for (int i = 0; i < numOfOrders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = long.Parse(Console.ReadLine());

                var price = pricePerCapsule * (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsuleCount);

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                total += price;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}