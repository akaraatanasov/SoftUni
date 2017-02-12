using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary
{
    public class Farming
    {
        public static void Main()
        {
            var materials = new Dictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>();
            string item = String.Empty;

            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            while (true)
            {
                var allInput = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 0; i < allInput.Length; i+=2)
                {
                    if (!materials.ContainsKey(allInput[i+1]))
                    {
                        materials.Add(allInput[i + 1], 0);
                    }

                    materials[allInput[i + 1]] += int.Parse(allInput[i]);

                    if (materials["shards"] >= 250)
                    {
                        item = "Shadowmourne";
                        materials["shards"] -= 250;

                        keyMaterials.Add("shards", materials["shards"]);
                        keyMaterials.Add("fragments", materials["fragments"]);
                        keyMaterials.Add("motes", materials["motes"]);

                        materials.Remove("shards");
                        materials.Remove("fragments");
                        materials.Remove("motes");
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        item = "Valanyr";
                        materials["fragments"] -= 250;

                        keyMaterials.Add("shards", materials["shards"]);
                        keyMaterials.Add("fragments", materials["fragments"]);
                        keyMaterials.Add("motes", materials["motes"]);

                        materials.Remove("shards");
                        materials.Remove("fragments");
                        materials.Remove("motes");
                        break;
                    }
                    else if (materials["motes"] >= 250)
                    {
                        item = "Dragonwrath";
                        materials["motes"] -= 250;

                        keyMaterials.Add("shards", materials["shards"]);
                        keyMaterials.Add("fragments", materials["fragments"]);
                        keyMaterials.Add("motes", materials["motes"]);

                        materials.Remove("shards");
                        materials.Remove("fragments");
                        materials.Remove("motes");
                        break;
                    }
                }

                if (!item.Equals(String.Empty))
                {
                    break;
                }

            }

            Console.WriteLine($"{item} obtained!");
            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in materials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

        }
    }
}