using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            int numFiles = int.Parse(Console.ReadLine());

            var DirNamesize = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numFiles; i++)
            {
                string[] input = Console.ReadLine().Split('\\');

                string root = input[0];
                string fileWithSize = input[input.Length - 1];

                var sizeNname = fileWithSize.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = sizeNname[0];
                long size = long.Parse(sizeNname[1]);

                if (!DirNamesize.ContainsKey(root))
                {
                    DirNamesize.Add(root, new Dictionary<string, long>());
                }

                if (!DirNamesize[root].ContainsKey(name))
                {
                    DirNamesize[root].Add(name, size);
                }
                else
                {
                    DirNamesize[root][name] = size;
                }

            }

            var query = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            string queryExtension = query[0];
            string queryRoot = query[2];

            if (DirNamesize.ContainsKey(queryRoot))
            {
                Dictionary<string, long> foundFiles = DirNamesize[queryRoot];

                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExtension))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}