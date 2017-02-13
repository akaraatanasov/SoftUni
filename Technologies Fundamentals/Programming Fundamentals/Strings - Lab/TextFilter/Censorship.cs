using System;
using System.Linq;

namespace TextFilter
{
    public class Censorship
    {
        public static void Main()
        {
            var banList = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var input = Console.ReadLine();

            foreach (var badWord in banList)
            {
                input = input.Replace(badWord, new string('*', badWord.Length));
            }

            Console.WriteLine(input);
        }
    }
}