using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            string singleDigit = "";
            string tensDigit = "";
            int tens = digit / 10;

            if (digit == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            else if (tens == 1)
            {
                tensDigit = "";
            }
            else if (tens == 2)
            {
                tensDigit = "twenty ";
                digit -= 20;
            }
            else if (tens == 3)
            {
                tensDigit = "thirty ";
                digit -= 30;
            }
            else if (tens == 4)
            {
                tensDigit = "fourty ";
                digit -= 40;
            }
            else if (tens == 5)
            {
                tensDigit = "fifty ";
                digit -= 50;
            }
            else if (tens == 6)
            {
                tensDigit = "sixty ";
                digit -= 60;
            }
            else if (tens == 7)
            {
                tensDigit = "seventy ";
                digit -= 70;
            }
            else if (tens == 8)
            {
                tensDigit = "eighty ";
                digit -= 80;
            }
            else if (tens == 9)
            {
                tensDigit = "ninety ";
                digit -= 90;
            }


            if (digit == 0)
            {
                singleDigit = " ";
            }
            else if (digit == 1)
            {
                singleDigit = "one";
            }
            else if (digit == 2)
            {
                singleDigit = "two";
            }
            else if (digit == 3)
            {
                singleDigit = "three";
            }
            else if (digit == 4)
            {
                singleDigit = "four";
            }
            else if (digit == 5)
            {
                singleDigit = "five";
            }
            else if (digit == 6)
            {
                singleDigit = "six";
            }
            else if (digit == 7)
            {
                singleDigit = "seven";
            }
            else if (digit == 8)
            {
                singleDigit = "eight";
            }
            else if (digit == 9)
            {
                singleDigit = "nine";
            }
            else if (digit == 10)
            {
                singleDigit = "ten";
            }
            else if (digit == 11)
            {
                singleDigit = "eleven";
            }
            else if (digit == 12)
            {
                singleDigit = "twelve";
            }
            else if (digit == 13)
            {
                singleDigit = "thirteen";
            }
            else if (digit == 14)
            {
                singleDigit = "fourteen";
            }
            else if (digit == 15)
            {
                singleDigit = "fifteen";
            }
            else if (digit == 16)
            {
                singleDigit = "sixteen";
            }
            else if (digit == 17)
            {
                singleDigit = "seventeen";
            }
            else if (digit == 18)
            {
                singleDigit = "eighteen";
            }
            else if (digit == 19)
            {
                singleDigit = "nineteen";
            }
            else if (digit == 100)
            {
                Console.WriteLine("one hundred");
                return;
            }

            Console.WriteLine(tensDigit + singleDigit);
        }
    }
}
