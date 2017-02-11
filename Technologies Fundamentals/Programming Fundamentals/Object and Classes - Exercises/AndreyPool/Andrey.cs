using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyPool
{
    public class Andrey
    {
        public static void Main()
        {
            int entries = int.Parse(Console.ReadLine());

            var Products = new Dictionary<string, double>();

            for (int i = 0; i < entries; i++)
            {
                var input = Console.ReadLine().Split('-').ToArray();

                Products[input[0]] = double.Parse(input[1]);
            }

            var inputClient = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output = new List<Customer>();

            while (!inputClient[0].Equals("end of clients"))
            {
                if (Products.ContainsKey(inputClient[1]))
                {
                    var customer = new Customer
                    {
                        Name = inputClient[0],
                        ShopList = new Dictionary<string, int>(),
                        Bill = 0
                    };

                    customer.ShopList[inputClient[1]] = int.Parse(inputClient[2]);

                    customer.Bill += Products[inputClient[1]] * int.Parse(inputClient[2]);

                    output.Add(customer);
                }

                inputClient = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            output = output.OrderBy(s => s.Name).ToList();
            double totalBill = 0;

            foreach (var result in output)
            {
                Console.WriteLine(result.Name);

                foreach (var item in result.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {result.Bill:f2}");

                totalBill += result.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");

        }
    }
}