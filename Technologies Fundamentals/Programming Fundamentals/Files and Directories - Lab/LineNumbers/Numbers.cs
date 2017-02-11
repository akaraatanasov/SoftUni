using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LineNumbers
{
    public class Numbers
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("Input.txt").ToArray();

            var result = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                result.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}