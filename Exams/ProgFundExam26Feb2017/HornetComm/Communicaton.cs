using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetComm
{
    public class Communicaton
    {
        public static void Main()
        {
            var broadcasts = new List<string>();
            var messages = new List<string>();

            int count = 0;
            var input = Console.ReadLine();
            while (!input.Equals("Hornet is Green"))
            {
                count++;
                if (count >= 1000)
                {
                    break;
                }

                var splitedInput = input.Split(' ').ToArray();
                string firstQuery = splitedInput[0];
                string secondQuery = splitedInput[2];
                string spliter = splitedInput[1];

                if (spliter.Equals("<->"))
                {
                    bool isPrivate = false;
                    foreach (var character in firstQuery.ToCharArray())
                    {
                        if (char.IsDigit(character))
                        {
                            isPrivate = true;
                        }
                        else
                        {
                            isPrivate = false;
                            break;
                        }
                    }

                    bool isBroadcast = false;
                    foreach (var character in firstQuery.ToCharArray())
                    {
                        if (!char.IsDigit(character))
                        {
                            isBroadcast = true;
                        }
                        else
                        {
                            isBroadcast = false;
                            break;
                        }
                    }

                    bool isValid = false;

                    foreach (var character in secondQuery.ToCharArray())
                    {
                        if (char.IsLetterOrDigit(character))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isPrivate && isValid)
                    {
                        string code = Reverse(firstQuery);
                        string codeNmessage = code + " -> " + secondQuery;
                        messages.Add(codeNmessage);
                    }

                    if (isBroadcast && isValid)
                    {
                        string frequency = new string(secondQuery.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                          char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
                        string frequencyNmessage = frequency + " -> " + firstQuery;
                        broadcasts.Add(frequencyNmessage);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Any())
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}