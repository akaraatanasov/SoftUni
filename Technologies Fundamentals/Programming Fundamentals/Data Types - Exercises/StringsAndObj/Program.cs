using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object sentence = hello + " " + world;
            string product = Convert.ToString(sentence);
            Console.WriteLine(product);
        }
    }
}