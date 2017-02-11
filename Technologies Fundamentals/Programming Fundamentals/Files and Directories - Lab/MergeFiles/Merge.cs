using System;
using System.Linq;
using System.IO;

namespace MergeFiles
{
    public class Merge
    {
        public static void Main()
        {
            var firstFile = File.ReadAllLines("FileOne.txt").ToList();

            var secondFile = File.ReadAllLines("FileTwo.txt").ToList();

            var result = firstFile.Concat(secondFile).ToList();

            result.Sort();

            foreach (var line in result)
            {
                File.AppendAllText("Output.txt", line + Environment.NewLine);
            }
        }
    }
}