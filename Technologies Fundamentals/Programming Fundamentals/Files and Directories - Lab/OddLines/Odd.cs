using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OddLines
{
    public class Odd
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("Input.txt").ToArray();

            var result = new List<string>();

            for (int i = 1; i < lines.Length; i+=2)
            {
                result.Add(lines[i]);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}