using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRecangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 8;
            var y = -1;
            var x1 = 2;
            var y1 = -3;
            var x2 = 12;
            var y2 = 3;
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                Console.WriteLine("Inside");
            else Console.WriteLine("Outside");
        }
    }
}
