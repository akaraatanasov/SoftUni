using System;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    public class TagReplace
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replace = @"[URL href=$1]$2[/URL]";
                var result = Regex.Replace(input, pattern, replace);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }

        }
    }
}