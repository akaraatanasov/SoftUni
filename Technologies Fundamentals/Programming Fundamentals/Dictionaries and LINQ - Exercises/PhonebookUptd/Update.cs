﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Update
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0].ToLower() == "s")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0].ToLower() == "a")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0].ToLower() == "listall")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command. Please try again!");
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}