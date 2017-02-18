using System;
using System.Linq;

namespace LettersChangeNumber
{
    public class Change
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double allSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];

                if (char.IsLetter(current[0]) && char.IsLetter(current[current.Length - 1]))
                {
                    bool flag = true;

                    for (int j = 1; j < current.Length - 1; j++)
                    {
                        if (!char.IsDigit(current[j]))
                        {
                            flag = false;
                        }
                    }

                    if (flag)
                    {
                        char firstLetter = current[0];
                        char lastLetter = current[input[i].Length - 1];
                        double number = double.Parse(current.Substring(1, current.Length - 2));

                        if (char.IsLower(current[0]))
                        {
                            number *= (current[0] - 96);
                        }
                        else
                        {
                            number /= (current[0] - 64);
                        }

                        if (char.IsLower(current[current.Length - 1]))
                        {
                            number += (current[current.Length - 1] - 96);
                        }
                        else
                        {
                            number -= (current[current.Length - 1] - 64);
                        }

                        allSum += number;
                    }                    
                }
              
            }

            Console.WriteLine($"{allSum:f2}");
        }
    }
}