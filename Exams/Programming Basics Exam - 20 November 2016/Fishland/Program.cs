using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int midiKG = int.Parse(Console.ReadLine());

            double smetkaPalamud = (skumriaPrice + skumriaPrice * 0.60) * palamudKG;
            double smetkaSafrid = (cacaPrice + cacaPrice * 0.80) * safridKG;
            double smetkaMidi = midiKG * 7.5;
            double result = smetkaPalamud + smetkaSafrid + smetkaMidi;

            Console.WriteLine("{0:0.00}", result);
        }
    }
}
