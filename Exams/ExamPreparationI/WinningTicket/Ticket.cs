using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    public class Ticket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            Regex pattern = new Regex(@"(\$|\@|\#|\^){6,10}");

            foreach (var ticket in tickets)
            {
                if (ticket.Count() != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10);

                    Match match1 = pattern.Match(firstHalf);
                    Match match2 = pattern.Match(secondHalf);
                    int count1 = match1.ToString().Count();
                    int count2 = match2.ToString().Count();
                    int count = 0;

                    count = Math.Min(count1, count2);

                    if (count >= 6 && count < 10)
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, count, match1.ToString()[0]);
                    }
                    else if (count == 10)
                    {
                        Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", ticket, count, match1.ToString()[0]);
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                }
            }
        }
    }
}