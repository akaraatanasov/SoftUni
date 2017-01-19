using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints += 5;
            }
            else if (points > 1000)
            {
                bonusPoints = bonusPoints + (points * 0.1);
            }
            else if (points > 100)
            {
                bonusPoints = bonusPoints + (points * 0.2);
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }

            else if (points % 5 == 0)
            {
                bonusPoints += 2;
            }

            Console.WriteLine("Bonus points: " + bonusPoints);
            Console.WriteLine("Total points: " + (points + bonusPoints));
        }
    }
}
