using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    public class Emails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            var email = String.Empty;

            var name = Console.ReadLine();

            while (!name.Equals("stop"))
            {
                email = Console.ReadLine();

                if (!email.EndsWith("us", StringComparison.InvariantCultureIgnoreCase) && !email.EndsWith("uk", StringComparison.InvariantCultureIgnoreCase))
                {
                    emails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var pair in emails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}