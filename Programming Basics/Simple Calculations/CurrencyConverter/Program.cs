using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            double newMoney = 0;
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            if (input == "BGN")
            {
                if (output == "USD")
                {
                    newMoney = money / 1.79549;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "EUR")
                {
                    newMoney = money / 1.95583;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "GBP")
                {
                    newMoney = money / 2.53405;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
            }

            else if (input == "USD")
            {
                if (output == "BGN")
                {
                    newMoney = money * 1.79549;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "EUR")
                {
                    newMoney = money * 0.91799;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "GBP")
                {
                    newMoney = money * 0.75073;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
            }

            else if (input == "EUR")
            {
                if (output == "USD")
                {
                    newMoney = money * 1.11536;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "BGN")
                {
                    newMoney = money * 1.95583;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "GBP")
                {
                    newMoney = money * 0.77165;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
            }

            else if (input == "GBP")
            {
                if (output == "USD")
                {
                    newMoney = money / 0.75073;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "EUR")
                {
                    newMoney = money / 0.83734;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
                else if (output == "BGN")
                {
                    newMoney = money * 2.53405;
                    Console.WriteLine(Math.Round(newMoney, 2) + " " + output);
                }
            }
        }
    }
}
