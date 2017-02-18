using System;

namespace MelrahShake
{
    public class Shake
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var pattern = Console.ReadLine();

            bool canShake = true;

            while (canShake)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex > -1 && lastIndex > -1 && pattern.Length > 0)
                {
                    firstIndex = input.IndexOf(pattern);
                    input = input.Remove(firstIndex, pattern.Length);
                    lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShake = false;
                    break;
                }
            }

            Console.WriteLine(input);
        }
    }
}